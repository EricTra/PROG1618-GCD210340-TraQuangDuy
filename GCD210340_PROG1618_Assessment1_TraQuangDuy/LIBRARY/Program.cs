using System;
using System.Collections.Generic;

namespace LIBRARY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Login login = new Login();
            //login.LoginSystem();
            //Login to use
            BookListManagement management = new BookListManagement();          
            management.Storage();          
            while (true)
            {
                int option = MenuSystem.enterUserChoice();
                switch (option) 
                {
                    case 1: //add book 
                        Console.Clear();
                        //Nhập password để có thể dùng được option này
                        //Trong function này có chứa 1 cái function để add thêm book
                        Console.WriteLine("This option need password to use!\n");
                        Console.WriteLine("1. Enter password to use");
                        Console.WriteLine("2. Go back to menu");
                        Console.Write("\nEnter your choice: ");
                        int adminChoice = int.Parse(Console.ReadLine());
                        if (adminChoice == 1)
                        {
                            Console.Write("Please enter password to use this option: ");
                            string security = Console.ReadLine();
                            while (string.Compare(security, "admin", true) != 0)
                            {
                                Console.WriteLine("Wrong password !!!");
                                Console.Write("Please Re-enter password to use this option: ");
                                security = Console.ReadLine();
                            }
                            Console.Clear();
                            Console.WriteLine("<========== OPTION 1: ADD BOOK ==========>");
                            management.BookStore(); //Add book
                            break;
                        }
                        else
                        { break;}
                        break;
                    case 2: //list book
                        Console.Clear();
                        Console.WriteLine("<========== OPTION 2: DISPLAY BOOKS' lIST ==========>");
                        management.DisplayBook();
                        break;
                    case 3: //search book
                        Console.Clear();
                        Console.WriteLine("<========== OPTION 3: SEARCH BOOK ==========>");
                        Console.WriteLine("You want to search book by:");
                        Console.WriteLine("1. By Book's ID");
                        Console.WriteLine("2. By Book's Title");
                        Console.WriteLine("3. By Book's Author");
                        Console.WriteLine("4. Return to Menu");
                        Console.Write("Enter your choice: ");
                        int find = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (find == 1)
                        {
                            Console.Clear();
                            Console.Write("Search by Book'ID: ");
                            int TmpID = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            if ( TmpID != null)
                            { management.IDSearchBook(TmpID); }
                            else
                            { Console.WriteLine("Invalid book !!!"); }
                            break;
                        }
                        else if (find == 2)
                        {
                            Console.Clear();
                            Console.Write("Input Title to search: ");
                            string Tmptitle = Console.ReadLine();
                            List<Book> listTitle = management.TitleSearch(Tmptitle);
                            if (listTitle.Count > 0)
                            {
                                foreach (var item in listTitle)
                                {
                                    Console.WriteLine(item.ToString());
                                }
                            }
                            else
                            {
                                Console.WriteLine("Cannot find book !!!");
                            }
                            break;                           
                        }
                        else if (find == 3)
                        {
                            Console.Clear();
                            Console.Write("Search by Author: ");
                            string TmpAuthor = Console.ReadLine();
                            List<Book> listAuthor = management.AuthorSearch(TmpAuthor);
                            if (listAuthor.Count > 0)
                            {
                                foreach (var item in listAuthor)
                                {
                                    Console.WriteLine(item.ToString());
                                }
                            }
                            else
                            {
                                Console.WriteLine("Cannot find book !!!");
                            }
                            break;
                        }
                        else if (find == 4)
                                break;
                        else
                        {
                            Console.WriteLine("Invalid choice !!!");                         
                        }
                        break;
                
                    case 4: //remove book
                        Console.Clear();
                        Console.WriteLine("<========== OPTION 4: DELETE BOOK ==========>");
                        Console.Write("Enter Book's ID to be delete : ");
                        int Del = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (Del != null)
                        { management.RemoveBook(Del); }
                        else
                        { Console.WriteLine("Invalid book !!!");}  
                        break;
                    case 5: //borrow book
                        Console.Clear();
                        Console.WriteLine("<========== OPTION 5: BORROW BOOK ==========>");
                        Console.Write("Enter Book's ID to borrow: ");
                        int borrow = int.Parse(Console.ReadLine());
                        management.Borrowbook(borrow);
                        break;
                    case 6: //return book
                        Console.Clear();
                        Console.WriteLine("<========== OPTION 6: RETURN BOOK ==========>");
                        Console.Write("Enter Book's ID to return: ");
                        int returnID = int.Parse(Console.ReadLine());
                        management.ReturnBook(returnID);
                        break;
                    case 7:
                        Console.WriteLine("Thank you for using our system!!!");
                        return;
                    default:
                        Console.WriteLine("Invalid option\nPlease try again !!!");
                        break;
                }
            }
        }
    }
}
