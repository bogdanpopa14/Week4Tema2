using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema
{
    public class Coada<type>
    {
        
        private List<type> coada = new List<type>();
        

        public void Enqueue(type nr)
        {
            coada.Add(nr);
            
        }
        public type Dequeue()
        {
            type a = coada[0];
            coada.RemoveAt(0);
            return a;
            
        }

        

       

        public void Print()
        {
            for (int i = 0; i < coada.Count; i++)
            {
                Console.WriteLine(coada[i]);
            }

        }
        public int Count()
        {
            
            return coada.Count;
        }
        public type Peek()
        {
            return coada[0];
        }
    }
}
