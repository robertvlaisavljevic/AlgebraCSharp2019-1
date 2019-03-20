using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._4_znamenke
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            Console.Write("Unesite prirodan broj: ");
            int a=int.Parse(Console.ReadLine());
            ArrayList arr = new ArrayList();

            while (a>0)
            {
                arr.Add(a % 10);
                a /= 10;
            }
            Console.WriteLine("Naopako: ");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
