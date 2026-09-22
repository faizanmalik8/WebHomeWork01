using Assignment1;
using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        List<Book> books= new List<Book>();
        bookDAL dal = new bookDAL();
        while (true)
        {
            Console.WriteLine("WelCome To Library\nSelect Options Below To Perform Operations:\n\n1.Add Book\n2.View All Books\n" +
                "3.Find Book By ID\n4.Create Backup File\n5.Exit");
            int opt = int.Parse(Console.ReadLine());
            if (opt == 1)
            {
                Book b1 = new Book();
                b1.addbook();
                dal.writebook(b1);
            }
            else if (opt == 2)
            {
                books=dal.readall();
                foreach (Book b in books)
                {
                    b.show();
                }
            }
            else if (opt == 3)
            {
                Console.WriteLine("Enter ID: ");
                int id = int.Parse(Console.ReadLine());
                Book b=new Book();
                b=dal.findbyid(id);
                if (b != null)
                {
                    b.show();
                }
                else Console.WriteLine("No Book Found! ");
            }
            else if (opt == 4)
            {
                dal.createbackup();
            }
            else if (opt == 5)
            {
                return;
            }
        }
    }
}