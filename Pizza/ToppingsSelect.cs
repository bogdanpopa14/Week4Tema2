using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    
    class ToppingsSelect
    {
        private double sum = 0;
        List<Toppings> lista = new List<Toppings>();
        public List<Toppings> SelectTopping()
        {
            Dictionary<string, double> listatopping = new Dictionary<string, double>
            {
                { "Chesse", 3 }, { "Meat", 4 }, { "Vegetables", 5 }
            };

            Console.WriteLine("Cate Toppinguri doriti: ");
            int nr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Selectati unul din urmatoarele toppinguri");
            for (int i = 0; i < listatopping.Count; i++)
            {
                Console.WriteLine($"{i+1}) {listatopping.Keys.ElementAt(i)} (${listatopping[listatopping.Keys.ElementAt(i)]})");

            }
            int[] numar = new int[nr];
            Console.WriteLine("Selectati de la 1-3: ");
            for (int i = 0; i < nr; i++)
            {
                numar[i] = Convert.ToInt32(Console.ReadLine());

                while (numar[i] >= 1 || numar[i] <= 4 )
                {
                    Console.WriteLine("Va rugam selectati un numar valid: ");
                    numar[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //List<Toppings> lista = new List<Toppings>();
            for (int i = 0; i < nr; i++)
            {
                Toppings toping = new Toppings(listatopping.Keys.ElementAt(numar[i ]-1), listatopping[listatopping.Keys.ElementAt(numar[i ]-1)]);

                lista.Add(toping);
                sum += toping.Cost;
                
            }

            return lista;
        }

        public double Suma()
        {
            return sum;
        }

        public void Print()
        {
            
            Console.WriteLine("Toppings: ");
            for (int i = 0; i < lista.Count; i++)
            {
                lista[i].Print();
            }
        }
    }
}
