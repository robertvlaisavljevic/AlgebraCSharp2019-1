using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3._1_Nasljeđivanje
{
    class Program
    {
        static void Main(string[] args)
        {

            Ucenik uc1 = new Ucenik();
            Ucenik uc2 = new Ucenik("Anica");
            Ucenik uc3 = new Ucenik("perica","peric");

            List<Ucenik> ucenici = new List<Ucenik> { uc1, uc2, uc3 };
            foreach (var item in ucenici)
            {
                Console.Write(item);
            }
            //dodaj vazace

            Vozac vo1 = new Vozac();
            Vozac vo2 = new Vozac();
            Vozac vo3 = new Vozac();

            List<Vozac> vozaci = new List<Vozac> { vo1, vo2, vo3 };
            foreach (var item in vozaci)
            {
                Console.Write(item);
            }

            Console.ReadKey();
        }
    }
}
