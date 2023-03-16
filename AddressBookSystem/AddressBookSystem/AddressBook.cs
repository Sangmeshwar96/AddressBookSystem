using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
        //Contact contact = new Contact();
        List<Contact> contacts = new List<Contact>();
        public Dictionary<string, AddressBook> addressbookDictionary = new Dictionary<string, AddressBook>();
        public void CreateContact()
        {
            Contact contact = new Contact();
            Console.WriteLine("Enter your first name :");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your last name :");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter your address :");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter your city :");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter your state :");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter your zip code :");
            contact.Zip = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your phone number :");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter your email :");
            contact.Email = Console.ReadLine();
            
            contacts.Add(contact);
        }
        public void Display()
        {
            Console.WriteLine("-------------------------------------------------");
            foreach(var contact in contacts)
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("Contact Details :\n" + "First Name : " + contact.FirstName + "\nLast Name : " + contact.LastName + "\nAddress : " + contact.Address + "\nCity : " + contact.City + "\nState : " + contact.State + "\nZipCode : " + contact.Zip + "\nPhone Number : " + contact.PhoneNumber + "\nEmail : " + contact.Email);
            }
            Console.WriteLine("\nThanking You For Adding Contact !!!");
        }
        public void EditContact(string name)
        {
            foreach (var contact in contacts)
            {
                if(contact.FirstName.Equals(name))
                {
                    Console.WriteLine("Choose What To Edit : \n1.First Name \n2.Last Name \n3.Address \n4.City \n5.State \n6.Email \n7.Zip \n8.Phone Number");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter New First Name :");
                            contact.FirstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter New Last Name :");
                            contact.LastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter New Address :");
                            contact.Address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter New City :");
                            contact.City = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter New State :");
                            contact.State = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter New Email :");
                            contact.Email = Console.ReadLine();
                            break;
                        case 7:
                            Console.WriteLine("Enter New Zip :");
                            contact.Zip = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("Enter New Phone Number :");
                            contact.PhoneNumber = Console.ReadLine();
                            break;
                    }
                }
            }
        }
        public void DeleteContact()
        {
            Console.WriteLine("Enter First Name To Delete Contact : ");
            string name = Console.ReadLine();
            Contact deletecontact = new Contact();
            foreach(var contact in contacts.ToList())
            {
                if(contact.FirstName.Equals(name))
                {
                    deletecontact = contact;
                }
                contacts.Remove(deletecontact);
            }
        }
        public void AddAddressBook(string bookName)
        {
            AddressBook addressBook = new AddressBook();
            addressbookDictionary.Add(bookName, addressBook);
            Console.WriteLine("AddressBook Created.");
        }
        public Dictionary<string, AddressBook> GetAddressBook()
        {
            return addressbookDictionary;
        }
    }
}
