using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class LimitedBook
    {
        private BookCreate carte { get; set; }
        public LimitedBook(BookCreate b1)
        {
            this.carte = b1;
        }
        public double Price
        {
            get
            {
                return  carte.Price *1.5;
                
            }
             private set
            {
                this.Price = carte.Price;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Title: {carte.Title}");
            carte.Autor.Print();
            Console.WriteLine($"Price: (${Price})");
        }
    }
}
