using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zbroj_razlikaP
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            Console.Write("Upisite 1. broj: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Upisite 2. broj ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Zbroj je: {0} \nRazlika je: {1} ", a + b, a - b);

            Console.ReadKey();
        }
    }
}
