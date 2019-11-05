using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class BookCreate
    {
        public string Title { get; set; }
        public Author Autor { get; set; }
        public double Price { get; set; }
        public void Print()
        {
            Console.WriteLine($"Titlu: {Title}");
            Autor.Print();
            
            Console.WriteLine($"Price: {Price}");
        }
    }
}
