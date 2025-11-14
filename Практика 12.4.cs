using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_12._4
{
    internal class Book
    {
        public readonly string ISBN;

        public string Title;

        public string Author;

        public Book(string isbn, string title, string author)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
        }

        public void Display()
        {
            Console.WriteLine("Информация о книге:");
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Название: " + Title);
            Console.WriteLine("Автор: " + Author);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book("228-1488", "Вся эта кровь мнееее", "Темный друн");
            myBook.Display();

            myBook.Title = "Цветы";
            myBook.Display();

            myBook.Author = "Фог";
            myBook.Display();

        }
    }
}
