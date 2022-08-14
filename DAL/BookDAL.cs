using BookBiz_Management_System.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.DAL
{
    public static class BookDAL
    {
        private static string filePath = Application.StartupPath + @"\data\Book.dat";  //data source
        private static string fileTemp = Application.StartupPath + @"\data\Temp.dat";

        //1. add a record to Employee.dat file
        public static void AddBook(Book book)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(book.ISBN + "," + book.Title + "," + book.UnitPrice + "," + book.QOH +"," + book.Category + "," + book.PublishYear+"," + book.PublisherName + "," +book.Authors);
            sWriter.Close();
            MessageBox.Show("New book has been saved.");

        }

        //get all Employee records from file
        public static List<Book> GetAllBooks()
        {
            List<Book> listB = new List<Book>();

            //step 1: Create an object of type StreamReader
            StreamReader sReader = new StreamReader(filePath);

            // Step 2: Read the file until teh end of the file
            //         - Read line by line
            //         - Split the line into an array of string based on seperator
            //         - Create an object of type Customer
            //         -Store data in the object Customer
            //         -Add the object to the listC
            //         -Close the file : VERY IMPORTANT

            string? line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                Book book = new Book();
                book.ISBN = fields[0];
                book.Title = fields[1];
                book.UnitPrice = Convert.ToDecimal(fields[2]);
                book.QOH = Convert.ToInt32(fields[3]);
                book.Category = fields[4];
                book.PublishYear = fields[5];
                book.PublisherName = fields[6];
                book.Authors = fields[7];
                listB.Add(book);
                line = sReader.ReadLine();
            }
            sReader.Close(); //Close the file
            return listB;
        }

        //Get book by ISBN
        public static Book? GetBookByISBN(string ISBN)
        {
            //step 1: get all records where name in records match input name
            List<Book> listB = GetAllBooks();
            Book book = (Book)(from element in listB
                                      where element.ISBN == ISBN
                                      select element);
            if (book != null)
            {
                return book;
            }
            else
            {
                MessageBox.Show("There is no book with this ISBN");
                return null;
            }
        }

        //Get Employee record dynamically
        public static List<Book>? GetBooksDync(string iSBN, string title, string author)
        {
            List<Book> listB = GetAllBooks();
            List<Book> books = (from element in listB
                                        where (element.ISBN == iSBN || element.Title == title ||
                                        element.Authors.Contains(author))
                                        select element).ToList();
            if (books != null)
            {
                return books;
            }
            else
            {
                MessageBox.Show("There is no book found");
                return null;
            }
        }

        public static void UpdateBooks(Book book)
        {
            StreamReader sReader = new StreamReader(filePath);
            StreamWriter sWriter = new StreamWriter(fileTemp, true);
            string line = sReader.ReadLine();

            while(line != null)
            {
                string[] fields = line.Split(',');
                if (fields[0] != book.ISBN)
                {
                    sWriter.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] + "," + fields[5] + ","
                        + fields[6] + "," + fields[7]);
                }
                line = sReader.ReadLine();
            }
            sWriter.WriteLine(book.ISBN + "," + book.Title + "," + book.UnitPrice + "," + book.QOH + "," + book.Category + "," + book.PublishYear + ","
                + book.PublisherName + "," + book.Authors);
            sReader.Close();
            sWriter.Close();
            File.Delete(filePath);
            File.Move(fileTemp, filePath);
        }

    }
}
