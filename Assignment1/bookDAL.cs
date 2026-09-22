using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class bookDAL
    {
        public void writebook(Book book)
        {
            StreamWriter write = new StreamWriter("books.txt", true);
            string line = $"{book.ID},{book.Title},{book.Author},{book.Price}";
            write.WriteLine(line);
            write.Close();
        }
        public List<Book> readall()
        {
            List<Book> list = new List<Book>();
            StreamReader read = new StreamReader("books.txt");
            string line = read.ReadLine();
            while (line != null)
            {
                Book b=new Book();
                string[] data=line.Split(",");
                b.ID=int.Parse(data[0]);
                b.Title=data[1];
                b.Author=data[2];
                b.Price=double.Parse(data[3]);
                list.Add(b);
                line=read.ReadLine();

            }
            read.Close();
            return list;
            
            

        }
        public Book findbyid(int id)
        {
            StreamReader read = new StreamReader("books.txt");
            string line = read.ReadLine();
            Book b = new Book();

            while (line != null)
            {
                string[] data= line.Split(",");
                int bid = int.Parse(data[0]);
                if (id == bid)
                {
                    b.ID = int.Parse(data[0]);
                    b.Title = data[1];
                    b.Author = data[2];
                    b.Price = double.Parse(data[3]);
                    break;
                }
            }
            return b;
        }
        public void createbackup()
        {
            StreamReader read = new StreamReader("books.txt");
            StreamWriter write = new StreamWriter("backup.txt",false);
            string line = read.ReadLine();
            while (line != null) {
                write.WriteLine(line);
                line=read.ReadLine();
            }
            read.Close ();
            write.Close ();
        }
    }
}
