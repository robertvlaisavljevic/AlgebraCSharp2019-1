using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x_znamenkasti_broj2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi broj: ");
            int a=int.Parse(Console.ReadLine());

            if (a < 0) a = -a;
            if (a>0 && a<10)
            
            {
                Console.WriteLine("broj je jednoznamenkast");
            }

            else if (a<100)

            {
                Console.WriteLine("broj je dvoznamenkast");
            }

            else if (a<1000)

            {
                Console.WriteLine("broj je troznamenkast");
            }

            else if (a>999)

            {
                Console.WriteLine("broj je viseznamenkast");
            }

            Console.ReadKey();
        }
    }
}
