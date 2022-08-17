using BookBiz_Management_System.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.DAL
{
    public class OrderItemDAL
    {
        private static string filePath = Application.StartupPath + @"\data\OrderItem.dat";  //data source
        private static string fileTemp = Application.StartupPath + @"\data\Temp.dat";  //data source
        //private List<Book> books = BookDAL.GetAllBooks();

        //1. add a record to file
        public static void AddOrderItem(OrderItem orderItem)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(orderItem.OrderId + "," + orderItem.ISBN + "," + orderItem.Title + "," +  orderItem.Quantity);
            sWriter.Close();
        }

        //2. find all records from files
        public static List<OrderItem> GetAllOrderItem()
        {
            List<OrderItem> listOI = new List<OrderItem>();
            //step 1: Create an object of type StreamReader
            StreamReader sReader = new StreamReader(filePath);
            // Step 2: Read the file until teh end of the file


            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                OrderItem item = new OrderItem();
                item.OrderId = fields[0];
               item.ISBN = fields[1];
                item.Title = fields[2]; 
                item.Quantity =Convert.ToInt32(fields[3]);
                listOI.Add(item);
                line = sReader.ReadLine();
            }
            sReader.Close(); //Close the file
            return listOI;
        }

        //3. find record by authoer name
        public static List<OrderItem>? GetItemDync(string orderId, string iSBN)
        {
            //step 1: get all records where name in records match input name
            List<OrderItem> itemList= GetAllOrderItem();
            List<OrderItem>itemListFound = (from element in itemList
                                       where element.OrderId == orderId || element.ISBN == iSBN
                                       select element).ToList();
            if (itemListFound != null)
            {
                return itemListFound;
            }
            else
            {
                MessageBox.Show("The item not found!");
                return null;
            }
        }

        //4. update record by author name

        //5. update record by author id

        //delete record by order id
        public static void Delete(string orderId, string ISBN)
        {
            StreamWriter sw = new StreamWriter(fileTemp, true);
            List<OrderItem> listOI = GetAllOrderItem();
            listOI.ForEach(el =>
            {
                if (el.OrderId != orderId && el.ISBN == ISBN)
                {
                    sw.WriteLine(el.OrderId + "," + el.ISBN + "," + el.Title + "," +el.Quantity);
                }
            });
            sw.Close();
            File.Delete(filePath);
            File.Move(fileTemp, filePath);
        }

    }
}
