﻿using System;

namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---Welcome To Address Book Management System---");
            AddressBook addressbook = new AddressBook();
            FileOperations fileOperations = new FileOperations();
            CSVHandler csvHandler = new CSVHandler();
            int choice;
            string bookName = "default";
            Console.WriteLine("Would You Like To \n1.Work on default AddressBook \n2.Create New AddressBook");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    addressbook.AddAddressBook(bookName);
                    break;
                case 2:
                    Console.WriteLine("Enter Name Of New Addressbook You want to create : ");
                    bookName = Console.ReadLine();
                    addressbook.AddAddressBook(bookName);
                    break;
            }
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select from below : "
                    +"\n1:Create Contact"
                    +"\n2:Display Contact"
                    +"\n3:Edit Contact"
                    +"\n4:Delete Contact"
                    +"\n6:Create New AddressBook "
                    +"\n7:Select Addressbook From Existing AddressBook"
                    +"\n8:Search by City"
                    +"\n9.View by City"
                    +"\n10.Count by City"
                    +"\n11.Sort By Name"
                    +"\n12.Sort By City"
                    +"\n13.Sort By State"
                    +"\n14.Sort By Zip"
                    +"\n15.Read Data From Text File"
                    +"\n16.Write Data To Text File"
                    +"\n17.Read Data From CSV File"
                    +"\n18.Write Data To CSV File"
                    +"\n19:To Exit Application\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressbook.CreateContact();
                        //addressbook.Display();
                        break;
                    case 2:
                        addressbook.Display();
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Edit Contact : ");
                        addressbook.EditContact("Sangmeshwar");
                        //addressbook.Display();
                        break;
                    case 4:
                        addressbook.DeleteContact();
                        //addressbook.Display();
                        break;
                    case 6:
                        Console.WriteLine("Enter Name For New AddressBook");
                        string newAddressbook = Console.ReadLine();
                        addressbook.AddAddressBook(newAddressbook);
                        Console.WriteLine("Would you like to Switch to " + newAddressbook);
                        Console.WriteLine("1.Yes \n2.No");
                        int c = Convert.ToInt32(Console.ReadLine());
                        if (c == 1)
                        {
                            bookName = newAddressbook;
                        }
                        break;
                    case 7:
                        Console.WriteLine("Enter Name Of AddressBook From Below List");
                        foreach (KeyValuePair<string, AddressBook> item in addressbook.GetAddressBook())
                        {
                            Console.WriteLine(item.Key);
                        }
                        while (true)
                        {
                            bookName = Console.ReadLine();
                            if (addressbook.GetAddressBook().ContainsKey(bookName))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("No such AddressBook found. Try Again.");
                            }
                        }
                        break;
                    case 8:
                        addressbook.SearchByCity();
                        break;
                    case 9:
                        addressbook.ViewByCity();
                        break;
                    case 10:
                        addressbook.CountByCity();
                        break;
                    case 11:
                        addressbook.SortAddressBookByFirstName();
                        break;
                    case 12:
                        addressbook.SortAddressBookByCity();
                        break;
                    case 13:
                        addressbook.SortAddressBookByState();
                        break;
                    case 14:
                        addressbook.SortAddressBookByZip();
                        break;
                    case 15: 
                        fileOperations.AddressBookFileReader();
                        break;
                    case 16:
                        fileOperations.AddressBookFileWrite();
                        break;
                    case 17:
                        csvHandler.ReadFromCSVFile();
                        break;
                    case 18:
                        csvHandler.WriteToCSVFile(addressbook.addressbookDictionary);
                        break;
                    case 19:
                        Console.WriteLine("\nThanking You !!!\nVisit Again !!!");
                        flag = false;
                        break;
                }
            }
        }
    }
}