using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma_i_prosjek
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0, b=0, c=0, d=0, e=0;


            Console.Write("Unesite prvi broj: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Unesite drugi broj: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Unesite treci broj: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Unesite cetvrti broj: ");
            d = int.Parse(Console.ReadLine());
            Console.Write("Unesite peti broj: ");
            e = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSuma ovih brojeva je: {0}", a+b+c+d+e);
            Console.WriteLine("\nProsjek ovih brojeva je {0}", (a + b + c + d + e) / 5);

            Console.ReadKey();

        }
        

    }
    
    

}
