using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pozitivan_ili_negativan_brojP
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.Write("Upisite broj: ");
            a = int.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("Broj je pozitivan", a);
            }
            else if (a<0)
            {
                Console.WriteLine("Broj je negativan", a);
            }
            else
            {
                Console.Write("Broj je nula");
            }
            Console.ReadKey();
        }
    }
}
