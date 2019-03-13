using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cijelobrojno_dijeljenje_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi broj: ");
            int a = int.Parse(Console.ReadLine());

            if (a%2==0)
            {
                Console.WriteLine("Broj je paran. ");
            }
            else
            {
                Console.WriteLine("Broj je neparan.");
            }
            if (a%3==0)
            {
                Console.WriteLine("Broj je djeljiv sa 3. ");
            }
            else
            {
                Console.WriteLine("Broj nije djeljiv sa 3 i daje ostatak: {0} ", a%3);
            }
            Console.ReadKey();
        }
    }
}
