using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace djeljivsa3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Brojevi od 1 do 100 koji su djeljivi sa 3 su: \n");

            for (int i = 3; i <=99; i+=3)
            {
                Console.Write("{0} ", i);
            }

            {
                Console.Write("\n\nBrojevi od 1 do 100 koji su djeljivi sa 3 su: \n");

                for (int i = 1; i <= 100; i ++)
                {
                    if (i%3==0)
                    {
                        Console.Write("{0} ", i);
                    }
                    
                }
            }
            Console.ReadKey();
        }
    }
}
