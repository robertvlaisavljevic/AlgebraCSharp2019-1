using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djelitelj00
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj: ");
            int a=int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                if (a%i==0)
                {
                    Console.Write("\n{0 }", i);
                }
            }
            Console.ReadKey();
        }
        
    }
}
