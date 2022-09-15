using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class BinaryFile
    {
        private BinaryWriter binaryWriter;
        private BinaryReader binaryReader;
        private Library library;

        public BinaryFile(Library library)
        {
            this.library = library;
        }




        /// <summary>
        /// Creates a BinaryFile
        /// </summary>
        public void CreateBinaryFile()
        {
            var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            var fi = new System.IO.FileInfo(@"../../abdi.bin");

            List<string> books = new List<string>();
            using (var binaryFile = fi.Create())
            {
                foreach (KeyValuePair<int, Book> book in library.GetAllBooks())
                {

                  
                    binaryFormatter.Serialize(binaryFile,  book.Value.Title);
               
                    binaryFile.Flush();
                }
            }
        }

    }
}
