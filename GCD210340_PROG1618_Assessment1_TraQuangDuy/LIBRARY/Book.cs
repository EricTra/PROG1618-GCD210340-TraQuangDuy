using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY
{
    class Book
    {
        //Book status
        public int bookId { get; set; }
        public string bookName {get; set; }
        public string author { get; set; }
        public string category { get; set; }
        public float bookPrice { get; set; }
        public int bookCount { get; set; }
        public int x { get; set; }

        //Borrow book
        public int userId { get; set; }
        public string userName { get; set; }
        public string userAddress { get; set; }
        public int borrowBookId { get; set; }
        public DateTime borrowDate { get; set; }
        public int borrowCount { get; set; }
        public Book()
        {

        }

        public Book(int BookId, string BookName, string Author, string Category, float BookPrice, int BookCount)
        {
            bookId = BookId;
            bookName=BookName;
            author = Author;
            category = Category;
            bookPrice = BookPrice;
            bookCount = BookCount;
        }

        public override string ToString()
        {
            return "Book's ID: " + bookId + "\n" + "Book's Name: " + bookName + 
            "\n" + "Book's Author: " + author + "\n" + "Genre: " + category + 
            "\n" +"Book's Price: " + bookPrice + "\n" + "Number of Books: " + bookCount + "\n";
        }
        public Book(int UserId, string UserName, string UserAddress, int BorrowBookId, DateTime BorrowDate, int BorrowCount)
        {
            userId = UserId;
            userName = UserName;
            userAddress = UserAddress;
            borrowBookId = BorrowBookId;
            borrowDate = BorrowDate;
            borrowCount = BorrowCount;
        }
    }
}

