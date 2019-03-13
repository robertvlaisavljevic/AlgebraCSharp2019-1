using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xznamenkasti_brojP
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.Write("Upisite broj: ");
            a = int.Parse(Console.ReadLine());

            if (a < 0) a = -a;
            if (a>0 && a<=9)
            {
                Console.Write("Broj je jednoznamenkast", a);
                
            }
            else if (a>9 && a<=99)
            {
                Console.Write("Broj je dvoznamenkast", a);
                
            }
            else if (a>99 && a<=999)
            {
                Console.Write("Broj je troznamenkast", a);
              
            }
            else
            {
                Console.Write("Broj je viseznamenkast", a);
                
            }
            Console.ReadKey();
        }
    }
}
