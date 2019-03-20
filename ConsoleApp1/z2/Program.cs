using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rijeci = new List<string>();
            

            while (true)
            {
                Console.WriteLine("Unesite rijec, za zavrsetak unesite rijec  kraj");
                string rijec = Console.ReadLine();
                if (rijec=="kraj")
                {
                    break;
                }
                else
                {
                    rijeci.Add(rijec);
                }
            }
            List<string> rijeciSaSlovomA = (from rijec in rijeci where rijec.ToString().StartsWith("a") select rijec).ToList();
            Console.WriteLine();
            List<string> rijeciSaSlovomB = (from rijec in rijeci where rijec.ToString().StartsWith("b") select rijec).ToList();
            Console.WriteLine();
            List<string> rijeciSaSlovomC = (from rijec in rijeci where rijec.ToString().StartsWith("c") select rijec).ToList();
            Console.WriteLine();


            Console.Write("rijeci koja pocinju sa slovom a: ");
            foreach (string rijec in rijeciSaSlovomA)
            {
                Console.Write(rijec + ",");
            }
            Console.Write("\nrijeci koja pocinju sa slovom b: ");
            foreach (string rijec in rijeciSaSlovomB)
            {
                Console.Write(rijec + ",");
            }
            Console.Write("\nrijeci koja pocinju sa slovom c: ");
            foreach (string rijec in rijeciSaSlovomC)
            {
                Console.Write(rijec + ",");
            }

            Console.ReadKey();
        }
    }
}
