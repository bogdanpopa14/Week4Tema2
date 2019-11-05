using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema
{
    class Program
    {
        static void Main(string[] args)
        {



            Stiva<int> s1 = new Stiva<int>();
            s1.Push(1);
            s1.Push(2);
            s1.Push(3);
            s1.Push(4);
            Console.WriteLine(s1.Peek());
            //s1.Print();
            //Console.WriteLine();
            //Console.WriteLine(s1.Pop());
            //Console.WriteLine();
            //s1.Print();
            //Console.WriteLine();
            //Console.WriteLine(s1.Pop());
            //Console.WriteLine();
            //s1.Print();


            //Console.WriteLine(c1.Count());
            Console.ReadLine();
        }
    }
}
