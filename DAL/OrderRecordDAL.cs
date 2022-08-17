using BookBiz_Management_System.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.DAL
{
    internal class OrderRecordDAL
    {
        private static string filePath = Application.StartupPath + @"\data\OrderRecord.dat";  //data source
        private static string fileTemp = Application.StartupPath + @"\Temp.dat";

        //1. add a record to file
        public static void AddOrderRecord(OrderRecord orderRecord)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(orderRecord.OrderId + "," + orderRecord.ClientName + "," + orderRecord.OrderMethod);
            sWriter.Close();
        }

        //2. find all records from files
        public static List<OrderRecord> GetAllOrderRecords()
        {
            List<OrderRecord> listO = new List<OrderRecord>();
            //step 1: Create an object of type StreamReader
            StreamReader sReader = new StreamReader(filePath);
            // Step 2: Read the file until teh end of the file

            string? line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                OrderRecord order = new OrderRecord();
                order.OrderId = fields[0];
                order.ClientName = fields[1];
                order.OrderMethod = fields[2];
                listO.Add(order);
                line = sReader.ReadLine();
            }
            sReader.Close(); //Close the file
            return listO;
        }

        //3. find record by authoer name
        public static List<OrderRecord>? GetOrderDync(string orderId, string clientName)
        {
            //step 1: get all records where records meet search criteria
            List<OrderRecord> listO = GetAllOrderRecords();
            List<OrderRecord> ordersFound = (from element in listO
                                       where element.OrderId == orderId || element.ClientName.Contains(clientName)
                                       select element).ToList();
            if (ordersFound != null)
            {
                return ordersFound;
            }
            else
            {
                MessageBox.Show("No order record found!");
                return null;
            }
        }

        //4. update record by order Id
        public static void UpdateOrder(OrderRecord orderRecord)
        {
            StreamReader sReader = new StreamReader(filePath);
            StreamWriter sWriter = new StreamWriter(fileTemp, true);

            string line = sReader.ReadLine();
            if(line != null)
            {
                string[] fields = line.Split(",");
                if (fields[0] != orderRecord.OrderId)
                {
                    sWriter.WriteLine(fields[0] +"," + fields[1] +"," + fields[2]);
                }
                line = sReader.ReadLine(); 
            }
            sWriter.WriteLine(orderRecord.OrderId + "," + orderRecord.ClientName + "," + orderRecord.OrderMethod);
            sWriter.Close();
            sReader.Close();
            File.Delete(filePath);
            File.Move(fileTemp, filePath);
        }
        //5. update record by clientName

        //delete record by order Id
        public static void Delete(string orderId)
        {
            StreamWriter sw = new StreamWriter(fileTemp, true);
            List<OrderRecord> listO = GetAllOrderRecords();
            listO.ForEach(el =>
            {
                if (el.OrderId != orderId)
                {
                    sw.WriteLine(el.OrderId + "," + el.ClientName + "," + el.OrderMethod);
                }
            });
            sw.Close();
            File.Delete(filePath);
            File.Move(fileTemp, filePath);
        }

    }
}
