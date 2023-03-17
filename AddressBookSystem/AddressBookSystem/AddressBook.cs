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
        Dictionary<string, AddressBook> addressbookDictionary = new Dictionary<string, AddressBook>();
        Dictionary<string, Contact> addressBookDictonary = new Dictionary<string, Contact>();
        Dictionary<string, List<Contact>> addressBookByCity = new Dictionary<string, List<Contact>>();

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
            if (contacts.Contains(contact))
            {
                Console.WriteLine("This Person Contact is already in the AddressBook.");
            }
            else
            {
                contacts.Add(contact);
                addressBookDictonary.Add(contact.FirstName, contact);
                Console.WriteLine("This Contact is added Sucessfully.");
            }
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
        public void SearchByCity()
        {
            Console.Write("Enter the City Name: ");
            string CityName = Console.ReadLine();
            Console.WriteLine("All the Contact of: " + CityName);
            foreach (var contact in contacts.FindAll(x => x.City == CityName))
            {
                Console.WriteLine("Name: " + contact.FirstName + " " + contact.LastName);
            }
        }
        public void ViewByCity()
        {
            Console.Write("Enter the City Name: ");
            string cityName = Console.ReadLine();
            Console.WriteLine("All the Contact details of: " + cityName);
            List<Contact> contactByCity = contacts.FindAll(x => x.City == cityName);
            addressBookByCity.Add(cityName, contactByCity);
            foreach (var contact in contacts.FindAll(x => x.City == cityName))
            {
                Console.WriteLine("\nContact Details\n" + "\n" + "First Name: " + contact.FirstName);
                Console.WriteLine("Last Name: " + contact.LastName);
                Console.WriteLine("Address: " + contact.Address);
                Console.WriteLine("City: " + contact.City);
                Console.WriteLine("State: " + contact.State);
                Console.WriteLine("Zip Code: " + contact.Zip);
                Console.WriteLine("PhoneNumber: " + contact.PhoneNumber);
                Console.WriteLine("E mail: " + contact.Email);
            }
        }
    }
}
