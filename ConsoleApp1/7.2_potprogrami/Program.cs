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
<<<<<<< HEAD
            HelloWorld();

            Program.HelloWorld();

            Console.WriteLine(HelloWorld("Ola"));

=======
           
            Program.HelloWorld();
            Console.WriteLine(HelloWorld("ola"));
>>>>>>> f8982c13a76fe32d1d9881eaca9ee6cd922d9b53
            Console.ReadKey();
        }
        static void HelloWorld()
        {
            Console.WriteLine("Helloooo");
        }
        static String HelloWorld(String poz)
        {
<<<<<<< HEAD
            return poz + " i tebi oj putniče" ;
=======
            return poz + " I tebi putnice";
>>>>>>> f8982c13a76fe32d1d9881eaca9ee6cd922d9b53
        }
    }
}
