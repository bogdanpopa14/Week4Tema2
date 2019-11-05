using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Author a1 = new Author { Name = "asa sda", Country = "Ro", Email = "bslkjdsa@som.com" };
            Author a2 = new Author { Name = "bla soe", Country = "Sp", Email = "mdsa@som.com" };

            BookCreate b1 = new BookCreate { Autor = a1, Price = 2.5, Title = "blA" };
            BookCreate b2 = new BookCreate { Autor = a2, Price = 3.5, Title = "www" };
            LimitedBook boc = new LimitedBook(b2);
            b1.Print();
            Console.WriteLine();
            boc.Print();
            Console.ReadLine();

           
        }
    }
}
