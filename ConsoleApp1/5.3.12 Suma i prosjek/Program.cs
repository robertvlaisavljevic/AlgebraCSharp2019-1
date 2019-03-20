using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._12_Suma_i_prosjek
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int suma = 0;
                float prosjek;
                for (int i = 1; i <= 5; i++)
                {
                    Console.Write("Unesite {0}. broj: ", i);
                    suma += int.Parse(Console.ReadLine());
                }
                prosjek = (float)suma / 5;
                Console.WriteLine("Suma ovih brojeva je {0} \nProsjek ovih brojeva je {1} ", suma, prosjek);
                
            }
            
            catch (Exception ex)
            {
                Console.WriteLine("GRESKA!", ex);
            }
            Console.ReadKey();


        }
        
    }
}
