using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokusaj
{
    class Program
    {
        static void Main(string[] args)
        {
            int zbroj = 0;
            

            for (int i = 1; i <= 2; i++)
            {
                Console.Write("Unesite {0 }. broj:", i);
                zbroj += int.Parse(Console.ReadLine());
            }

            

            Console.WriteLine("zbroj= {0}", zbroj);
            Console.ReadKey();
        }
    }
}
