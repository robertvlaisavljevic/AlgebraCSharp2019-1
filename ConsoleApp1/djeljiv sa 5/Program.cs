using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace djeljiv_sa_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Brojevi od 1 do 100 koji su djeljivi sa 5: \n");

            for (int i = 5; i <= 100; i+=5)
            {

                Console.Write("{0 }  ", i);
            }
            Console.ReadKey();
        }
    }
}
