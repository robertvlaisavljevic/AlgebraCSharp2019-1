using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Unesi broj: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Unesen je broj {0}", a);

            }
            catch (Exception)
            {
                Console.WriteLine("Dogodila se greska ");
                Console.WriteLine("Nije unesen broj. " );

                
            }
            finally
            {
                Console.Write("Pritisnite nesto za kraj... ");
            }
            Console.ReadKey();

        }
    }
}
