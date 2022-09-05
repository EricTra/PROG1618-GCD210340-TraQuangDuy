using System;
using System.Collections.Generic;

namespace LibraryManagement
{
    //Defining a class Book
    class Book
    {
        public int bookId;
        public string bookName;
        public float bookPrice;
        public int bookCount;
        public int x;
    }
    //Defining a class Borrow
    class BorrowDetails
    {
        public int userId;
        public string userName;
        public string userAddress;
        public int borrowBookId;
        public DateTime borrowDate;
        public int borrowCount;
    }

    class Program
    {
        static List<Book> bookList = new List<Book>();
        static List<BorrowDetails> borrowList = new List<BorrowDetails>();
        static Book book = new Book();
        static BorrowDetails borrow = new BorrowDetails();

        //Password verfication and Menu 
        static void Main(string[] args)
        {
            Console.Write("======<Welcome to Quang Duy library>====== \nEnter your password :");
            string password = Console.ReadLine();

            while (password != "123")
            {
                Console.WriteLine("Wrong password!");
                Console.Write("Please Re-enter your password: ");
                password = Console.ReadLine();
            }
            if (password == "123")
            {
                Console.WriteLine("lOGIN SUCCESS!");
                bool close = true;
                while (close)
                {
                    Console.WriteLine("\n======<Menu option>======\n" +
                    "1)Add book\n" +
                    "2)Delete book\n" +
                    "3)Search book\n" +
                    "4)Borrow book\n" +
                    "5)Return book\n" +
                    "6)Close\n\n");
                    Console.Write("Choose your option from menu:");

                    int option = int.Parse(Console.ReadLine());

                    if (option == 1)
                    {
                        Console.Clear();
                        GetBook();
                       
                    }
                    else if (option == 2)
                    {
                        Console.Clear();
                        RemoveBook();
                   
                    }
                    else if (option == 3)
                    {
                        Console.Clear();
                        SearchBook();
                        
                    }
                    else if (option == 4)
                    {
                        Console.Clear();
                        Borrow();
                        
                    }
                    else if (option == 5)
                    {
                        Console.Clear();
                        ReturnBook();
                       
                    }
                    else if (option == 6)
                    {
                        Console.WriteLine("Thank you for using our system");
                        close = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option\nPlease try again !!!");
                    }
                }
            }
        }

        //To add book details to the Library database
        public static void GetBook()
        {
            Book book = new Book();
            Console.WriteLine("Book Id:{0}", book.bookId = bookList.Count + 1);
            Console.Write("Book Name:");
            book.bookName = Console.ReadLine();
            Console.Write("Book Price:");
            book.bookPrice = float.Parse(Console.ReadLine());
            Console.Write("Number of Books:");
            book.x = book.bookCount = int.Parse(Console.ReadLine());
            bookList.Add(book);
        }

        //To delete book details from the Library database 
        public static void RemoveBook()
        {
            Book book = new Book();
            Console.Write("Enter Book id to be deleted : ");

            int Del = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.bookId == Del))
            {
                bookList.RemoveAt(Del - 1);
                Console.WriteLine("Book id - {0} has been deleted", Del);
            }
            else
            {
                Console.WriteLine("Invalid Book id");
            }

            bookList.Add(book);
        }

        //To search book details from the Library database using Book id 
        public static void SearchBook()
        {
            Book book = new Book();
            Console.Write("Search by BOOK id :");
            int find = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.bookId == find))
            {
                foreach (Book searchId in bookList)
                {
                    if (searchId.bookId == find)
                    {
                        Console.WriteLine("Book id :{0}\n" +
                        "Book name :{1}\n" +
                        "Book price :{2}\n" +
                        "Book Count :{3}", searchId.bookId, searchId.bookName, searchId.bookPrice, searchId.bookCount);
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", find);
            }
        }

        //To borrow book details from the Library
        public static void Borrow()
        {
            Book book = new Book();
            BorrowDetails borrow = new BorrowDetails();
            Console.WriteLine("User id : {0}", (borrow.userId = borrowList.Count + 1));
            Console.Write("Name :");

            borrow.userName = Console.ReadLine();

            Console.Write("Book id :");
            borrow.borrowBookId = int.Parse(Console.ReadLine());
            Console.Write("Number of Books : ");
            borrow.borrowCount = int.Parse(Console.ReadLine());
            Console.Write("Address :");
            borrow.userAddress = Console.ReadLine();
            borrow.borrowDate = DateTime.Now;
            Console.WriteLine("Date - {0} and Time - {1}", borrow.borrowDate.ToShortDateString(), borrow.borrowDate.ToShortTimeString());

            if (bookList.Exists(x => x.bookId == borrow.borrowBookId))
            {
                foreach (Book searchId in bookList)
                {
                    if (searchId.bookCount >= searchId.bookCount - borrow.borrowCount && searchId.bookCount - borrow.borrowCount >= 0)
                    {
                        if (searchId.bookId == borrow.borrowBookId)
                        {
                            searchId.bookCount = searchId.bookCount - borrow.borrowCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Your book is out of stock", searchId.bookCount);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", borrow.borrowBookId);
            }
            borrowList.Add(borrow);
        }

        //To return borrowed book to the library 
        public static void ReturnBook()
        {
            Book book = new Book();
            Console.WriteLine("Enter following details :");

            Console.Write("Book id : ");
            int returnId = int.Parse(Console.ReadLine());

            Console.Write("Number of Books:");
            int returnCount = int.Parse(Console.ReadLine());

            if (bookList.Exists(y => y.bookId == returnId))
            {
                foreach (Book addReturnBookCount in bookList)
                {
                    if (addReturnBookCount.x >= returnCount + addReturnBookCount.bookCount)
                    {
                        if (addReturnBookCount.bookId == returnId)
                        {
                            addReturnBookCount.bookCount = addReturnBookCount.bookCount + returnCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Count exists the actual count");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", returnId);
            }
        }
    }
}