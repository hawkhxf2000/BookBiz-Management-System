using BookBiz_Management_System.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.DAL
{
    internal class BookAuthorDAL
    {
        //define file path
        private static string filePath = Application.StartupPath + @"\data\BookAuthor.dat";  //data source
        //Add Publisher object
        public static void AddBookAuthor(BookAuthor bookAuthor)
        {
            //step 1: Create a StreamWriter to open the file
            StreamWriter sWriter = new StreamWriter(filePath, true);

            //step 2: Write the object data to file
            sWriter.WriteLine(bookAuthor.ISBN + "," + bookAuthor.AuthorId);

            //step 3: close writer
            sWriter.Close();
        }

        //Get all publishers
        public static List<BookAuthor> GetAllBookAuthor()
        {
            List<BookAuthor> bookAuthorList = new List<BookAuthor>();

            //Step 1: Create a StreamReader object to read the file
            StreamReader sReader = new StreamReader(filePath);

            //Step 2: read the lines from file and set it to a list of Publisher objects
            string line = sReader.ReadLine();
            while (line != null)
            {
                String[] fields = line.Split(',');
                BookAuthor bookAuthor = new BookAuthor();
               bookAuthor.ISBN = fields[0];
               bookAuthor.AuthorId = Convert.ToInt32(fields[1]);
                bookAuthorList.Add(bookAuthor);
                line = sReader.ReadLine();  //read the line again
            }
            //step 3:close StreamWriter
            sReader.Close();
            return bookAuthorList;
        }

    }
}
