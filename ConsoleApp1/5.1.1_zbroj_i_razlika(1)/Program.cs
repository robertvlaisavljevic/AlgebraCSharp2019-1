using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1._1_zbroj_i_razlika_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = 0, b = 0;

            Console.WriteLine("Unesite prvi broj: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Zbroj {0}: ", a + b);
            Console.WriteLine("Razlika {0}: ", a - b);

            Console.ReadKey();
        }
    }
}
