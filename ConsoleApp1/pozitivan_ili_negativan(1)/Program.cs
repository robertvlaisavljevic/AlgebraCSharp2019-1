using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pozitivan_ili_negativan_1_
{
    class Program
    {
        static void Main(string[] args)
        {
      
            Console.Write("Unesite broj: ");
            int a = int.Parse(Console.ReadLine());

            if (a>0)
            {
                Console.WriteLine("Broj je pozitivan ");

            }
            else if (a<0)
            {
                Console.WriteLine("Broje je negativan ");

                
            }
            else 
            {
                Console.WriteLine("Broje je nula ");


            }

            Console.ReadKey();
        }
    }
}
