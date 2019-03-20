using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umnozak_i_kvocijentP
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0, b = 0;

            Console.Write("Upisite 1. broj: ");
            a = float.Parse(Console.ReadLine());

            Console.Write("Upisite 2. broj: ");
            b = float.Parse(Console.ReadLine());

            Console.Write("Umnozak je: {0} \nKvocijent je: {1}", (a * b), (decimal)a / (decimal)b);
            Console.ReadKey();


        }
    }
}
