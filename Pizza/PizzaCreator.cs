using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class PizzaCreator
    {
        public string Name { get; set; }
        BaseSelect blat = new BaseSelect();
        ToppingsSelect topinguri = new ToppingsSelect();
        
        public void Create()
        {
            
            blat.SelectBase();
            topinguri.SelectTopping();
            
        }

        public void Print()
        {
            
            Console.WriteLine();
            Console.WriteLine($"Pizza: {Name}");
            double total = topinguri.Suma() + blat.Cost();
            blat.Print();
            topinguri.Print();
            Console.WriteLine($"Cost total: (${total})");
        }
    }
}
