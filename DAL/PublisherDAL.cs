using BookBiz_Management_System.BLL;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.DAL
{
   public class PublisherDAL
    {
        //define file path
        private static string filePath = Application.StartupPath + @"\data\Publisher.dat";  //data source
        //Add Publisher object
        public static void AddPublisher(Publisher publisher)
        {
            //step 1: Create a StreamWriter to open the file
            StreamWriter sWriter = new StreamWriter(filePath, true);

            //step 2: Write the object data to file
            sWriter.WriteLine(publisher.PublisherId + "," +publisher.PublisherName);

            //step 3: close writer
            sWriter.Close();
        }

        //Get all publishers
        public static List<Publisher> GetAllPublishers()
        {
            List<Publisher> publisherList = new List<Publisher>();

            //Step 1: Create a StreamReader object to read the file
            StreamReader sReader = new StreamReader(filePath);

            //Step 2: read the lines from file and set it to a list of Publisher objects
            string line = sReader.ReadLine();
            while(line != null)
            {
                String[] fields = line.Split(',');
                Publisher publisher = new Publisher();
                publisher.PublisherId =Convert.ToInt32(fields[0]);
                publisher.PublisherName = fields[1];
                publisherList.Add(publisher);
                line = sReader.ReadLine();  //read the line again
            }
            //step 3:close StreamWriter
            sReader.Close();
            return publisherList;
        }

        //Get publisher by Id;
        public static Publisher GetPublisherById(int id)
        {
            List<Publisher> publishers = GetAllPublishers();
          Publisher  publisher = (from el in publishers
                        where el.PublisherId == id
                        select el).ToList()[0];

            return publisher;
        }
    }
}
