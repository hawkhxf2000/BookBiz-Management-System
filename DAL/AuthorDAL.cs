using BookBiz_Management_System.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.DAL
{
    public class AuthorDAL
    {
        private static string filePath = Application.StartupPath + @"\data\Author.dat";  //data source
        //private List<Book> books = BookDAL.GetAllBooks();

        //1. add a record to file
        public static void AddAuthor(Author author)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(author.AuthorId + "," + author.FirstName + "," +author.LastName +"," + author.Email);
            sWriter.Close();
        }

        //2. find all records from files
        public static List<Author> GetAllAuthor()
        {
            List<Author> listA = new List<Author>();
            //step 1: Create an object of type StreamReader
            StreamReader sReader = new StreamReader(filePath);
            // Step 2: Read the file until teh end of the file
           

            string? line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                Author author = new Author();
                author.AuthorId = Convert.ToInt32(fields[0]);
                author.FirstName = fields[1];
                author.LastName = fields[2];
                author.Email = fields[3];
                listA.Add(author);
                line = sReader.ReadLine();
            }
            sReader.Close(); //Close the file
            return listA;
        }

        //3. find record by authoer name
        public static List<Author>? GetAuthorByName(string firstName, string lastName)
        {
            //step 1: get all records where name in records match input name
            List<Author> listA = GetAllAuthor();
            List<Author> authorList = (from element in listA
                                          where element.FirstName == firstName || element.LastName == lastName
                                          select element).ToList();
            if(authorList != null)
            {
                return authorList;
            }
            else
            {
                MessageBox.Show("There is no author named " + firstName + " " +lastName + "!");
                return null;
            }
        }

        //4. update record by author name

        //5. update record by author id

        //delete record by author id
    }
}
