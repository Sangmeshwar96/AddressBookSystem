using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBookSystem;

namespace AddressBookSystem
{
    public class FileOperations
    {
        AddressBook addressBook = new AddressBook();
        string addressBookFile = "C:\\Users\\hp\\source\\repos\\AddressBookSystem\\AddressBookSystem\\Files\\AddressBook.txt";
        public void AddressBookFileReader()
        {
            using (StreamReader streamReader = File.OpenText(addressBookFile))
            {
                string readFile = "";
                while ((readFile = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(readFile);
                }
            }
        }
        public void AddressBookFileWrite()
        {
            using (StreamWriter streamWriter = File.AppendText(addressBookFile))
            {
                streamWriter.WriteLine("\nContact Details\n");
                foreach (var contact in addressBook.addressBookDictonary)
                {
                    streamWriter.WriteLine("First Name: " + contact.Value.FirstName);
                    streamWriter.WriteLine("Last Name: " + contact.Value.LastName);
                    streamWriter.WriteLine("Address: " + contact.Value.Address);
                    streamWriter.WriteLine("City: " + contact.Value.City);
                    streamWriter.WriteLine("State: " + contact.Value.State);
                    streamWriter.WriteLine("Zip Code: " + contact.Value.Zip);
                    streamWriter.WriteLine("PhoneNumber: " + contact.Value.PhoneNumber);
                    streamWriter.WriteLine("Email: " + contact.Value.Email);
                }
                streamWriter.Close();
                Console.WriteLine(File.ReadAllText(addressBookFile));
            }
        }
    }
}
