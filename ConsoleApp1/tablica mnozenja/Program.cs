using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablica_mnozenja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\t\t\t\tTABLICA MNOZENJA\n\n");
            
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0}\t ", (i*j));
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
