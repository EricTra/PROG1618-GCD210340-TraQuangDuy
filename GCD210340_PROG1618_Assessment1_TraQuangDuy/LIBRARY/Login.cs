using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY
{
    class Login
    {
        public void LoginSystem()
        {
            Console.WriteLine("======< Welcome to Library Management System >======");
            Console.Write("Enter your user name: ");
            string userName = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
            while (string.Compare(password, "123", true) != 0 || string.Compare(userName, "admin", true) != 0)
            {
                Console.WriteLine("Wrong username or password !!!");
                Console.Write("Please Re-enter your username: ");
                userName = Console.ReadLine();
                Console.Write("Please Re-enter your password: ");
                password = Console.ReadLine();
            }
            Console.WriteLine("lOGIN SUCCESS!");
        }
        public void SecurityForAdd()
        {
            Console.WriteLine("This option need password to use!\n");
            Console.WriteLine("1. Enter password to use");
            Console.WriteLine("2. Go back to menu");
            Console.Write("\nEnter your choice: ");
            int adminChoice = int.Parse(Console.ReadLine());
            switch (adminChoice)
            {
                case 1:
                    Console.Write("Please enter password to use this option: ");
                    string security = Console.ReadLine();
                    while (string.Compare(security, "admin", true) != 0)
                    {
                        Console.WriteLine("Wrong password !!!");
                        Console.Write("Please Re-enter password to use this option: ");
                        security = Console.ReadLine();
                    }
                    Console.Clear();
                    BookListManagement getbooklist = new BookListManagement();
                    getbooklist.BookStore();
                    break;
                default:
                    break;
            }
        }

        public void SecurityForDelete()
        {
            Console.WriteLine("This option need password to use!\n");
            Console.WriteLine("1. Enter password to use");
            Console.WriteLine("2. Go back to menu");
            Console.Write("\nEnter your choice: ");
            int adminChoice = int.Parse(Console.ReadLine());
            switch (adminChoice)
            {
                case 1:
                    Console.Write("Please enter password to use this option: ");
                    string security = Console.ReadLine();
                    while (string.Compare(security, "admin", true) != 0)
                    {
                        Console.WriteLine("Wrong password !!!");
                        Console.Write("Please Re-enter password to use this option: ");
                        security = Console.ReadLine();
                    }
                    Console.Clear();
                    BookListManagement getbooklist = new BookListManagement();
                    getbooklist.BookStore();
                    break;
                default:
                    break;
            }
        }
    }
}

