using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma_prvih_100P
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Suma prvih 100 brojeva iznosi: ");
            int suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                suma+=i;
            }
            Console.Write("{0} ", suma);
            Console.ReadKey();
        }
    }
}
