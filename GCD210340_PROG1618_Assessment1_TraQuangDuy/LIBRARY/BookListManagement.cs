using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY
{
    internal class BookListManagement : Book
    {
        public List<Book> bookList = new List<Book>();
        public BookListManagement() { }


        public void Storage()
        {
            bookList.Add(new Book(1, "Les Miserables", "Victor Hugo", "Darama", 100, 1));
            bookList.Add(new Book(2, "Harry Potter", "J.K Rowling", "Darama", 200, 2));
            bookList.Add(new Book(3, "The Green Mile", "Stephen King", "Darama", 300, 3));
            bookList.Add(new Book(4, "Sherlock Holmes", "Conan Doyle", "Darama", 400, 4));
        }

        //To add book details to the Library database
        public void BookStore()
        {
            Console.Write("How many book do you want to add? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                BookListManagement booksystem = new BookListManagement();
                //ID
                Console.Write("Book's ID: ");
                booksystem.bookId = int.Parse(Console.ReadLine());
                //Name (Title)
                Console.Write("Book's Name: ");
                booksystem.bookName = Console.ReadLine();
                //Author
                Console.Write("Book's Author: ");
                booksystem.author = Console.ReadLine();
                //Category
                Console.Write("Genre: ");
                booksystem.category = Console.ReadLine();
                //Price
                Console.Write("Book's Price: ");
                booksystem.bookPrice = float.Parse(Console.ReadLine());
                //Count
                Console.Write("Number of Books: ");
                booksystem.x = booksystem.bookCount = int.Parse(Console.ReadLine());
                Console.WriteLine();
                bookList.Add(booksystem);
            }
        }
        public void IDSearchBook (int IDs)
        {
            foreach (var item in bookList)
            {
                if (item.bookId == IDs)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        public List<Book> TitleSearch(string title)
        {
            List<Book> book = new List<Book>();
            foreach (var item in bookList)
            {
                if (item.bookName.Contains(title)) book.Add(item);
            }
            return book;
        }

        public List<Book> AuthorSearch(string author)
        {
            List<Book> book = new List<Book>();
            foreach (var item in bookList)
            {
                if (item.author.Contains(author)) book.Add(item);
            }
            return book;
        }

        public void RemoveBook(int Del)
        {
            foreach (var item in bookList)
            {
                if (item.bookId == Del)
                {
                    bookList.Remove(item);
                    Console.WriteLine("Book has been Delete\n");
                    break;
                }
            }
        }
        public void DisplayBook()
        {
            foreach (var item in bookList)
            {
                Console.WriteLine(item.ToString());
            }
        }


        //To return borrowed book to the library 
        public void ReturnBook(int IDs)
        {
            Console.Write("Number of Books: ");
            int returnCount = int.Parse(Console.ReadLine());
            foreach (var item in bookList)
            {
                if (item.bookId == IDs)
                {
                    item.bookCount = item.bookCount + returnCount;
                    Console.WriteLine("\nYou have returned a book");
                    return;
                }
            }
        }

        //borrow a book
        public void Borrowbook(int ID)
        {
            Console.Write("Name : ");
            userName = Console.ReadLine();
            Console.Write("Number of Books : ");
            borrowCount = int.Parse(Console.ReadLine());
            Console.Write("Address : ");
            userAddress = Console.ReadLine();
            borrowDate = DateTime.Now;
            Console.WriteLine("Date - {0} and Time - {1}", borrowDate.ToShortDateString(), borrowDate.ToShortTimeString());
            foreach (var item in bookList)
            {
                if (item.bookId == ID)                
                {
                    if (item.bookCount >= item.bookCount - borrowCount && item.bookCount - borrowCount >= 0)
                    {  
                        item.bookCount = item.bookCount - borrowCount;
                        Console.WriteLine();
                        Console.WriteLine("You have borrowed a book" + "\nPlease remember to return it on time\n");
                        break;             
                    }
                    else
                    {
                        Console.WriteLine("\nYour book is out of stock");
                        break;
                    }
                }                 
            }
        }                
    }
}

