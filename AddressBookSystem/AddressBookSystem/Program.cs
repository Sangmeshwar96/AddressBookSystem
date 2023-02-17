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
                Console.WriteLine("\nSelect 1: For Creating Contact"+ "\nSelect 2: Edit Contact"+ "\nSelect 3: Delete Contact"+ "\nSelect 4: Display Contact" + "\nSelect 5: Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressbook.CreateContact();
                        //addressbook.Display();
                        break;
                    case 2:
                        Console.WriteLine("Edit Contact : ");
                        addressbook.EditContact("Sangmeshwar");
                        //addressbook.Display();
                        break;
                    case 3:
                        addressbook.DeleteContact();
                        //addressbook.Display();
                        break;
                    case 4:
                        addressbook.Display();
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("\nThanking You !!!\nVisit Again !!!");
                        flag = false;
                        break;
                }
            }
        }
    }
}