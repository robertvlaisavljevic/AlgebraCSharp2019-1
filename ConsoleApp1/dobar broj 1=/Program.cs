using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dobar_broj_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            //radi
            Console.Write("Unesi broj: ");
            int a = int.Parse(Console.ReadLine());

            if (a%5==0 || a%3==0)
            {
                Console.WriteLine("Broj je dobar ");
            }
            else
            {
                Console.WriteLine("Broje NIJE dobar ! ");
            }
            
           

            Console.ReadKey();
        }
        
    }
}
