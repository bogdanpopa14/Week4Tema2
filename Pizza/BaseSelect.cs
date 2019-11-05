using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
   
    class BaseSelect
    {
        private double cost = 0;
        private Base baza = new Base("asa", 3);
        public Base SelectBase()
        {
            Dictionary<string, double> listablat = new Dictionary<string, double> 
            {
                { "Regular", 3 }, { "Thick", 4 }, { "Italian", 5 } 
            };

            Console.WriteLine("Selectati unul din urmatoarele blaturi");
            for (int i = 0; i < listablat.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {listablat.Keys.ElementAt(i)} (${listablat[listablat.Keys.ElementAt(i)]})");

            }

            //Console.WriteLine("Selectati unul din urmatoarele tipuri de blat:");
            //Console.WriteLine("1) Regular ($3)");
            //Console.WriteLine("2) Thick ($4)");
            //Console.WriteLine("3) Italian ($5)");


            Console.WriteLine("Apasati un numar de la 1-3");
            int b1 = Convert.ToInt32(Console.ReadLine());
            while(b1 <= 1 || b1 >= 4 )
            {
                Console.WriteLine("Va rugam selectati un numar valid: ");
                b1 = Convert.ToInt32(Console.ReadLine());
            }

             Base blat = new Base(listablat.Keys.ElementAt(b1 - 1), listablat[listablat.Keys.ElementAt(b1 - 1)]);
            cost = blat.Cost;
            baza = blat;
            return blat;
        }
        public double Cost()
        {
        
            return cost;
        }
        public void Print()
        {
            baza.Print();
        }
        
    }
    
}
