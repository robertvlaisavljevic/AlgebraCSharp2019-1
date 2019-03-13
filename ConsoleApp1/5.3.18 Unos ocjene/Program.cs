using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._18_Unos_ocjene
{
    class Program
    {
        static void Main(string[] args)
        {
            
                string ocjena = "";
                bool dobarunos = false;
                while (!dobarunos)

                {
                    Console.Write("Unesite ocjenu: ");
                    ocjena = Console.ReadLine();
                    try
                    {

                        if (ocjena == "1" || ocjena == "2" || ocjena == "3" || ocjena == "4" || ocjena == "5")
                        {
                            dobarunos = true;
                        }
                        if (!dobarunos)
                        {
                        throw new Exception("Unesena je kriva ocjena\nOcjena mora biti od 1 do 5");
                        }
                    

                    }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                }
            
            Console.WriteLine("Ocjena je ispravno unesena");
            Console.ReadKey();
        }
    }
}
