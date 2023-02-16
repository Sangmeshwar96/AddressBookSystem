using System;

namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---Welcome To Address Book Management System---");
            AddressBook addressbook = new AddressBook();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select 1: For Creating Contact"+ "\nSelect 2: Edit Contact" + "\nSelect 3: Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressbook.CreateContact();
                        addressbook.Display();
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Edit Contact : ");
                        addressbook.EditContact("Sangmeshwar");
                        addressbook.Display();
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}