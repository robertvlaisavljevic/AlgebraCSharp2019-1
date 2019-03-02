using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neparni_do_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Neparni brojevi od 3 do 20 su: ");
            for (int i = 3; i <= 19; i+=2)
            {
              Console.Write("{0 }  ", i);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Neparni brojevi od 20 do 3 su: ");
            for (int a = 19; a >=3; a -= 2)
            {
                Console.Write("{0 }  ", a);

            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Parni brojevi od 20 do 3 su: ");
            for (int a = 20; a >= 4; a -= 2)
            {
                Console.Write("{0 }  ", a);

            }
            Console.WriteLine("\n\nParni brojevi od 20 do 3 su: ");
            for (int a = 20; a >= 3; a -- )
            {
                if (a%2==0)
                {
                    Console.Write("{0 }  ", a);
                }
                

            }
            Console.ReadKey();
        }
    }
}
