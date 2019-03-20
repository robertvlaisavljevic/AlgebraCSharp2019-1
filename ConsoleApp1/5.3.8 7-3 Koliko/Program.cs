using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._8_7_3_Koliko
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 7 == 0 && !(i % 3 == 0))
                {
                    a++; 
                }

            }
            Console.Write("{0} ", a);
            Console.ReadKey();
        }
    }
}
