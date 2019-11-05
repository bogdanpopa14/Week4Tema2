using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema

{
    public class Stiva<type>
    {

        private List<type> stiva = new List<type>();


        public void Push(type nr)
        {
            stiva.Add(nr);

        }

        public type Pop()
        {
            type a = stiva[stiva.Count - 1];
            stiva.RemoveAt(stiva.Count - 1);
            return a;

        }

        public void Print()
        {
            for (int i = 0; i < stiva.Count; i++)
            {
                Console.WriteLine(stiva[i]);
            }

        }
        public int Count()
        {

            return stiva.Count;
        }
        public type Peek()
        {
            return stiva[stiva.Count - 1];
        }
    }
}
