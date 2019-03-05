using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._3_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr  = new ArrayList();
            
            int a = -1;
            Console.WriteLine("Unesite prirodne brojeve, za kraj unesite 0");
            

            while (a != 0)
            {
                a = int.Parse(Console.ReadLine());
                arr.Add(a);
            }
            
            arr.Sort();

            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
