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
        private static string filePath = Application.StartupPath + @"\data\Author.dat";
        //private static string filePath = "C:\Users\hawkh\source\repos\hawkhxf2000\BookBiz Management System\data\Employees.dat";
        //private static string fileTemp = Application.StartupPath + @"\data\Temp.dat";

        public static void Add(Author author)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(author.AuthorId + "," + author.Name + "," + author.Email);
            sWriter.Close();
            MessageBox.Show("Author Data has been saved.");
        }

        public static List<Author> GetAllAuthor()
        {
            List<Author> listA = new List<Author>();
            //step 1: Create an object of type StreamReader
            StreamReader sReader = new StreamReader(filePath);
            // Step 2: Read the file until teh end of the file
            //         - Read line by line
            //         - Split the line into an array of string based on seperator
            //         - Create an object of type Author
            //         -Store data in the object Author
            //         -Add the object to the listA
            //         -Close the file : VERY IMPORTANT

            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                Author author = new Author();
                author.AuthorId = Convert.ToInt32(fields[0]);
                author.Name = fields[1];
                author.Email = fields[2];
                listA.Add(author);
                line = sReader.ReadLine();
            }
            sReader.Close(); //Close the file
            return listA;
        }

        public static List<Author> GetAuthorByName(string name)
        {
            //step 1: get all records where name in records match input name
            List<Author> listA = GetAllAuthor();
            List<Author> authorList = (from element in listA
                                          where element.Name == name
                                          select element).ToList();
            if(authorList != null)
            {
                return authorList;
            }
            else
            {
                MessageBox.Show("There is no author named " + name + "!");
                return null;
            }
        }
    }
}
