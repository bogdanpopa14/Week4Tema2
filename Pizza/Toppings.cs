using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Toppings
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public Toppings(string name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public void Print()
        {
            Console.WriteLine($"\t{Name} (${Cost})");
        }
    }
}

