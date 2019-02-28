using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umnozak_kvocijent2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            
            Console.WriteLine("Unesite prvi broj: ");
            a=int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite drugi broj: ");
            b=int.Parse(Console.ReadLine());

            //uvijek prvo decimal pa int
            Console.WriteLine("Umnozak ovih brojeva je: {0}", a*b);
            Console.WriteLine("Kvocijent ovih brojeva je: {0}", (decimal)a / (decimal)b);

            Console.ReadKey();

        }
    }
}
