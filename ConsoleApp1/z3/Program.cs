using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobil automobil = new Automobil();

            Console.Write("Unesite naziv automobila: ");
            automobil.Naziv = Console.ReadLine();
            Console.Write("Unesite godinu proizvodnje: ");
            automobil.GodinaProizvodnje = int.Parse(Console.ReadLine());
            Console.Write("Unesite osnovnu cijenu automobila: ");
            automobil.OsnovnaCijena = double.Parse(Console.ReadLine());

            Console.WriteLine("Starost: {0}\nUkupna cijena: {1}", automobil.Starost(), automobil.UkupnaCijena());

            Console.ReadKey();

        }
    }
}
