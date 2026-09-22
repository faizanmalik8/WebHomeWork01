using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class Book
    {
        public int ID;
        public string Title;
        public string Author;
        public double Price;

        public Book() { }
        public Book(int id, string title, string author, double price) { 
            this.ID = id;
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }
        public void addbook()
        {
            Console.WriteLine("Enter ID: ");
            int id=int.Parse(Console.ReadLine());
            this.ID = id;
            Console.WriteLine("Enter Book Title: ");
            string title=Console.ReadLine();
            this.Title = title;
            Console.WriteLine("Enter Author Name: ");
            string author = Console.ReadLine();
            this.Author = author;
            Console.WriteLine("Enter Book Price: ");
            double price =double.Parse(Console.ReadLine());
            this.Price= price;

        }
        public void show()
        {
            Console.WriteLine($"\nID:{this.ID},\nTitle:{this.Title},\nAuthor:{this.Author},\nPrice:{this.Price}\n");
        }

    }
}
