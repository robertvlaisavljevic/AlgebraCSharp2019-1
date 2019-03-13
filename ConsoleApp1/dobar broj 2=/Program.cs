using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dobar_broj_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Unesi broj :");
                int a = int.Parse(Console.ReadLine());

                if (a % 4 == 0 && !(a < 100))
                {
                    Console.WriteLine("Broj je dobar. ");
                }
                else
                {
                    Console.WriteLine("Broj NIJE dobar. ");
                }
            }
            catch
            {
                Console.WriteLine("GRESKA! ");
            }
            Console.ReadKey();
        }
    }
}
