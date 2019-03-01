using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma_i_prosjek_zadaci
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma=0;
            float prosjek;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Unesite {0 } broj:", i);
                suma+=int.Parse(Console.ReadLine());
            }

            prosjek=(float)suma / 5;

            Console.WriteLine("suma= {0}\nProsjek = {1}", suma, prosjek);
            Console.ReadKey();

        }
    }
}
