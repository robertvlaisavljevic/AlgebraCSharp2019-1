using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2_potprogrami
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Program.HelloWorld();
            Console.WriteLine(HelloWorld("ola"));
            Console.ReadKey();
        }
        static void HelloWorld()
        {
            Console.WriteLine("Helloooo");
        }
        static String HelloWorld(String poz)
        {
            return poz + " I tebi putnice";
        }
    }
}
