using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                float a = 0, b = 0;
                string operacija = "";
                string odgovor = "D";

                while (odgovor == "D" || odgovor == "d")
                {

                    Console.Write("upisite 1.broj: ");
                    a = float.Parse(Console.ReadLine());
                    Console.Write("Upisite 2. broj: ");
                    b = float.Parse(Console.ReadLine());


                    Console.Write("Upisite racunsku operaciju; +,-,*,/ : ");
                    operacija = Console.ReadLine();

                    switch (operacija)
                    {


                        case "+":
                            Console.WriteLine("Zbroj iznosi: {0}", a + b);
                            break;

                        case "-":
                            Console.WriteLine("Razlika iznosi: {0}", a - b);
                            break;

                        case "*":
                            Console.WriteLine("Umnozak iznosi: {0}", a * b);
                            break;

                        case "/":
                            Console.WriteLine("Kvocijent iznosi: {0}", a / b);
                            break;

                        default:
                            Console.WriteLine("Nepoznata racunska operacija!");
                            break;
                    }
                    Console.WriteLine("Zelite li racunati ponovo:(D/N) ?");
                    odgovor = Console.ReadLine();

                }
            }
            catch (FormatException ex)
            {
                Console.Write("GRESKA!\nMorate upisati broj", ex.ToString());
                
            }

            Console.ReadKey();
        }
    }
}
