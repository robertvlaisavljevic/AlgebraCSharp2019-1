using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u_intervalu
{
    class Program
    {
        static void Main(string[] args)
        {
            //brojevi od 100 do 200
            Console.Write("Unesi broj od 100 do 200: ");
            int a=int.Parse(Console.ReadLine());
            

            if (a>=100 && a<=200)
            {
                Console.WriteLine("broj je u intervalu ");
            }
              
            else
            {
                Console.WriteLine("broj nije u intervalu ");
            }

            //brojevi od 500 do 1000
            Console.Write("Unesi broj od 500 do 1000: ");
            int b = int.Parse(Console.ReadLine());

            if (b >= 500 && b <= 1000)
            {
                Console.WriteLine("broj je u intervalu ");
            }

            else
            {
                Console.WriteLine("broj nije u intervalu ");
            }
            Console.ReadKey();
        }
    }
}
