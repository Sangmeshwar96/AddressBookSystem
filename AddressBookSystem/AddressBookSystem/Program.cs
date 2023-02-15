using System;

namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---Welcome To Address Book Management System---");
            AddressBook addressbook = new AddressBook();
            addressbook.CreateContact();
            addressbook.Disply();
            Console.ReadLine();
        }
    }
}