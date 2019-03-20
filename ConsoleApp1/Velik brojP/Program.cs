using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Velik_brojP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 0;
                Console.Write("Upisite broj: ");
                a = int.Parse(Console.ReadLine());
                if (a > 99)
                {
                    Console.Write("Broj je VELIK.", a);
                }
                else
                {
                    Console.Write("Broje NIJE velik.", a);
                }
                
            }
            catch (Exception broj)
            {
                Console.Write("Broj je POGRESNO upisan!\nProvjerite jeste li dobro upisali broj.", broj.ToString());
            }
            Console.ReadKey();
        }
    }
}
