using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neparni_do_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Neparni brojevi od 3 do 20 su: ");
            for (int i = 3; i <= 19; i+=2)
            {
              Console.Write("{0 }  ", i);
            }
            Console.ReadKey();
        }
    }
}
