using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            float a=0, b = 0;
            string operacija = "";

            Console.WriteLine("Unesite prvi broj: ");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("Unesite drugi broj: ");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("Unesite racunsku operaciju (+,-,* ili /): ");
            operacija = Console.ReadLine();


            switch (operacija)
            {
                case "+":

            Console.WriteLine("Zbroj ovih brojeva je {0}:", a+b);
                    break;

                case "-":

             Console.WriteLine("Razlika ovih brojeva je {0}:", a - b);
                    break;

                case "*":

             Console.WriteLine("Umnozak ovih brojeva je {0}:", a * b);
                    break;

                case "/":

             Console.WriteLine("Kvocijent ovih brojeva je {0}:", (decimal)a / (decimal)b);
                    break;
                default:
                    Console.WriteLine("Nepoznata operacija!");
                    break;
            }
            


            Console.WriteLine("Pritisnite neku tipku za kraj...");
            Console.ReadKey();
        }
        
    }
}
