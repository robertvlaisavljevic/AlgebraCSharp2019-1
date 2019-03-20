using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pozdrav("Pero");
            Pozdrav("Pero", "Peric");
            Console.ReadKey();
        }
        static void Pozdrav(string ime)
        {
            Console.WriteLine("dobar dan, " + ime + "!");
        }
        static void Pozdrav (string ime, string prezime)
        {
            Console.WriteLine("dobar dan, " + ime + " " + prezime + "!");
        }
    }
}
