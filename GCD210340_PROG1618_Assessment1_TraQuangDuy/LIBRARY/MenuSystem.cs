using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY
{
    class MenuSystem
    {
        public static int enterUserChoice()
        {
            Console.Write("======<Menu option>======\n" +
            "1)Add book\n" +
            "2)Display book list\n" +
            "3)Search book\n" +
            "4)Delete book\n" +
            "5)Borrow book\n" +
            "6)Return book\n" +
            "7)Close\n");
            Console.WriteLine("=========================");
            Console.Write("Choose your option from menu: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();
            return choice;
        }
    }
}
