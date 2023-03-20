using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class CSVHandler
    {
        public AddressBook addressBook = new AddressBook();
        string addressBookCSVFile = "C:\\Users\\hp\\source\\repos\\AddressBookSystem\\AddressBookSystem\\Files\\AddressBookCSV.csv";
        public void ReadFromCSVFile()
        {
            using (StreamReader reader = new StreamReader(addressBookCSVFile))
            {
                using (CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    Console.WriteLine("Below are Contents of CSV File");
                    List<Contact> contactRecord = csv.GetRecords<Contact>().ToList();
                    foreach (Contact contact in contactRecord)
                    {
                        Console.WriteLine(contact.ToString());
                    }
                }
            }
        }
        public void WriteToCSVFile(Dictionary<string, AddressBook> addressBookDictionary)
        {
            using (StreamWriter writer = new StreamWriter(addressBookCSVFile))
            {
                using (CsvWriter csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    foreach (AddressBook obj in addressBookDictionary.Values)
                    {
                        List<Contact> contactRecord = obj.contacts.ToList();
                        csv.WriteRecords(contactRecord);
                    }
                    Console.WriteLine("\nSuccessfully added to CSV file.");
                    csv.Dispose();
                }
            }
        }
    }
}
