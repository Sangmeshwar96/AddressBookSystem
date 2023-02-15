using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
        Contact contact = new Contact();
        public void CreateContact()
        {
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
        }
        public void Disply()
        {
            Console.WriteLine("Contact Details :\n"+"First Name : "+contact.FirstName+"\nLast Name : "+contact.LastName+"\nAddress : "+contact.Address+"\nCity : "+contact.City+"\nState : "+contact.State+"\nZipCode : "+contact.Zip+"\nPhone Number : "+contact.PhoneNumber+"\nEmail : "+contact.Email);
            Console.WriteLine("\nThanking You !!!");
        }

    }
}
