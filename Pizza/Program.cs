using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            PizzaCreator p1 = new PizzaCreator();
            p1.Name = "Quatro";
            p1.Create();
            p1.Print();
            Console.ReadLine();
        }
    }
}
