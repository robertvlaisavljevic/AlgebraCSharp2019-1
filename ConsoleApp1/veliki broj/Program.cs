using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veliki_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.Write("Unesi broj: ");
            a=int.Parse(Console.ReadLine());

            if (a>99)
            {
                Console.WriteLine("Broj je VELIK !");
            }
            else
            {
                Console.WriteLine("Broj NIJE velik" );
            }

            Console.ReadKey();


        }
    }
}
