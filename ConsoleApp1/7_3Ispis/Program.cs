using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3Ispis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Brojevi od 1 do 100 koji su djeljivi sa 7 ali nisu djeljivi sa 3\n");
            for (int i = 1; i < 100; i++)
            {
                if (i%7==0 && (!(i%3==0)))
                {
                    
                    Console.Write("{0}  ", i);
                }
            }
            Console.ReadKey();
        }
    }
}
