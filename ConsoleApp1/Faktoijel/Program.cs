using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktoijel
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            long faktorijel = 1;
            Console.Write("Unesite broj: ");
            x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                faktorijel *= i;
            }
            Console.Write("{0}!={1}", x, faktorijel);
            Console.ReadKey();
        }
    }
}
