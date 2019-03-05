using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._4NOVO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string a =Console.ReadLine();
            int ua = int.Parse(Console.ReadLine());
            a.Reverse();
            Console.Write("original {0}, naopako {1} ", ua, new string(a.Reverse().ToArray()));
            Console.ReadKey();
        }
        
    }
}
