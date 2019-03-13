using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_Primjer
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciraj novi objekt klase ucenik
            Ucenik uc1 = new Ucenik();



            //incijalizacija objekta
            Console.WriteLine("Unesi ime ucenika");
            uc1.ime = Console.ReadLine();

            Console.WriteLine("Unesi prezime ucenika");
            uc1.prezime = Console.ReadLine();

            Console.WriteLine("Unesi ocjenu iz matematike ");
            uc1.ocjenaIzMatematike =int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi ocjenu iz biologije");
            uc1.ocjenaIzBiologije = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi ime iz engleskog");
            uc1.ocjenaIzEngleskog = int.Parse(Console.ReadLine());

            Console.WriteLine("Prosjek je: "+ uc1.Prosjek());

            //instanciraj novi objekt klase ucenik
            Ucenik uc2 = new Ucenik("Perica");

            Console.WriteLine("Ime je: "+ uc1.ime+" i "+uc2.ime);

            //List<Ucenik> ucenici = new List<Ucenik> { uc1, uc2 }; //moze i ovako
            List<Ucenik> ucenici = new List<Ucenik> { uc1, uc2 };

            ucenici.Add(uc1);
            ucenici.Add(uc2);

            foreach (var item in ucenici)
            {
                Console.WriteLine(item);
            }


            

            Console.ReadKey();


        }
    }
}
