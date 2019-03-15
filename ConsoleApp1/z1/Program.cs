using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite prirodan broj: ");
            int a = int.Parse(Console.ReadLine());
            ArrayList arr = new ArrayList();

            while (a > 0)
            {
                arr.Add(a % 10);
                a /= 10;
            }
            Console.WriteLine("Naopako: ");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
