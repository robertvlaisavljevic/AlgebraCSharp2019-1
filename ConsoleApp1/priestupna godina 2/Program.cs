using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace priestupna_godina_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upisite godinu: ");
            int a=int.Parse(Console.ReadLine());

            if ((a%4==0 && (!(a%100==0)))||a%400==0 )
            {
                Console.WriteLine("Godina je prijestupna. ");
            }

            else 
            {
                Console.WriteLine("Godina nije prijestupna. ");
            }
            Console.ReadKey();



        }
    }
}
