using BookBiz_Management_System.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.DAL
{
    public class ClientDAL
    {
        private static string filePath = Application.StartupPath + @"\data\Client.dat";  //data source

        //Save new client to file
        public static void SaveClient(Client client)
        {
            //step 1: Create a streamwriter object to open the file, ready to write data
            StreamWriter sWriter = new StreamWriter(filePath, true);

            //step 2: write the data to file
            sWriter.WriteLine(client.ClientId + "," + client.ClientName + "," + client.PhoneNumber + "," + client.FaxNumber + "," +client.Email + "," +  client.Address + ","
                + client.PostalCode + "," + client.BankAccount + "," + client.CreditLimit);

            //step 3: close streamwriter
            sWriter.Close();
         }
        
        //Get all clients from file
        public static List<Client> GetAllClients()
        {
            //step 1: crete a streamreader object for reading the file
            StreamReader sReader = new StreamReader(filePath);

            //step 2: create a list of client objects
            List<Client> listC = new List<Client>();

            //step 3: read a line from file with streamreader
            string line = sReader.ReadLine();

            //step 4: judge if line is null or not, if not null, read the data and save it to a new client object.
            while(line != null)
            {
                Client client = new Client();
                String[] fields = line.Split(',');
                client.ClientId = Convert.ToInt32(fields[0]);
                client.ClientName = fields[1];
                client.PhoneNumber = fields[2];
                client.FaxNumber = fields[3];
                client.Email = fields[4];
                client.Address = fields[5];
                client.PostalCode = fields[6];
                client.BankAccount = fields[7];
                client.CreditLimit = Convert.ToInt32(fields[8]);
                listC.Add(client);
                line = sReader.ReadLine();
            }
            sReader.Close();
            return listC;
        }

        //Get list of client from file dynamically
        public static List<Client>? GetClientsDync(int clientId, string name, string phoneNumber, string faxNumber)
        {
            List<Client> clients = GetAllClients();
            List<Client> clientsFound = (from client in clients
                                         where (client.ClientId == clientId || (client.ClientName.ToLower().Contains(name.ToLower()) && !string.IsNullOrEmpty(name)) || client.PhoneNumber == phoneNumber || client.FaxNumber == faxNumber)
                                         select client)
                                .ToList();
            if(clientsFound != null)
            {
                return clientsFound;
            }
            MessageBox.Show("No client record found!");
            return null;
        }

    }
}
