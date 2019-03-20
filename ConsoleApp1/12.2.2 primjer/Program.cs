using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2._2_primjer
{
    class Program
    {
        static void Main(string[] args)
        {
            //ucitavamo datumski podatak
            Console.Write("Unesite podatak tipa DateTime: ");
            DateTime d1 = DateTime.Parse(Console.ReadLine());

            //iSPISUJEMO DATUME
            Console.WriteLine("Datum: ");
            Console.WriteLine(d1);
            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(d1.ToShortDateString());

            //Ispisujem vrijeme
            Console.WriteLine("Vrijeme: ");
            Console.WriteLine(d1.ToShortTimeString());

            //Ispis dana u tjednu
            Console.WriteLine("Dan u tjednu");
            //ako ne kastamo, ispisuje slova
            Console.WriteLine(d1.DayOfWeek);
            Console.WriteLine((int)d1.DayOfWeek);

            //korisnicko formiranje
            //sistemsko vrijeme ispisujemo na preciznost
            //tisucinke sekunde
            Console.WriteLine("Sada je tocno: ");
            d1 = DateTime.Now;

            Console.WriteLine(d1.ToString("MMMM,dddd yyyy HH:mm:ss ffff"));

            //koliko dana ima do Nove godine
            //1)kreiram novi datum za novu godinu
            DateTime dNG = new DateTime(2020, 1, 1);

            //2)oduzimam tekuci datum od datuma nove godine
            TimeSpan ts = dNG.Subtract(d1);

            //3)ispisujemo koliko ima do nove godine
            Console.WriteLine("Do nove godine ima: ");
            Console.WriteLine("dana: " + ts.Days);
            Console.WriteLine("i sati: " + ts.Hours);

            Console.WriteLine("TO JE UKUPNO SATI: " + ts.TotalHours);
            Console.WriteLine("ili {0} dana {1} sati {2} minuta {3} sekundi", ts.Days, ts.Hours, ts.Minutes, ts.Seconds);

            //POVECANJE DATUMA
            Console.WriteLine("Danas je izdana potvrda na 6 mjeseci.");
            DateTime DatumIzdavanja = DateTime.Now;
            DateTime DatumIsteka = DatumIzdavanja.AddMonths(6);
            Console.WriteLine("Datum isteka: {0}", DatumIsteka);

            Console.ReadKey();




        }
    }
}
