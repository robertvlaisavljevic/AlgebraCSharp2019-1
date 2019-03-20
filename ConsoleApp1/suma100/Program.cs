using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma100
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int suma=0;
            for (int i = 0; i <= 100; i++)
            {
                
                suma+=i;
            }
            Console.Write("Suma prvih 100 brojeva je :\n {0} ", suma);

            {
                //dodana suma prvih 100 parnih brojeva
                int sum = 0;
                for (int i = 0; i <= 100; i+=2)
                {

                    sum += i;
                }
                Console.Write("\nSuma prvih 100 parnih brojeva je :\n {0} ", sum);
            }

            Console.ReadKey();
        }
        
        
    }
}
