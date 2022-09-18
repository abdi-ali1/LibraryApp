using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class BinaryFile
    {
        private Library library;

        public BinaryFile(Library library)
        {
            this.library = library;
        }

        /// <summary>
        /// Creates a BinaryFile
        /// </summary>
        public void CreateBinaryFile(string path)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileInfo fi = new FileInfo(@path);


            using (var binaryFile = fi.Create())
            {
                binaryFormatter.Serialize(binaryFile, library.GetAllBooks());
                binaryFile.Flush();
            }


        }


        public List<Book> ReadBinaryFile(string path)
        {
            //Format the object as Binary  
            BinaryFormatter formatter = new BinaryFormatter();

            //Reading the file from the server  
            FileStream fs = File.Open(path, FileMode.Open);
            List<Book> savedBooks =  (List<Book>)formatter.Deserialize(fs);
            fs.Flush();
            fs.Close();
            fs.Dispose();


            return savedBooks;
        }


    }
}
