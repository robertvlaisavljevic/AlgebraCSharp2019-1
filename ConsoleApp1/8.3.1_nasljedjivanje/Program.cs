﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _8._1._2_Automobil;

namespace _8._3._1_nasljedjivanje
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucenik uc1 = new Ucenik();   // Osoba() i Ucenik()  razlog?
            Ucenik uc2 = new Ucenik("Anica");    // Osoba()
            Ucenik uc3 = new Ucenik("perica","Perić");  //Osoba()

<<<<<<< HEAD
            uc3.PrijaviIspit(new Ispit("Engleski"));

=======
            uc3.Prijaviispit(new Ispit("Engleski"));
>>>>>>> 5aaecac3b02ef9522628931f10fd9ff44f09e710
            // generic list
            List<Ucenik> ucenici = new List<Ucenik> { uc1, uc2, uc3 };

            foreach (var item in ucenici)
            {
                Console.WriteLine(item);
            }

            // collection base lista (kao Arraylist)
<<<<<<< HEAD
            Studenti studenti = new Studenti();
            studenti.Add(uc1);
            studenti.Add(uc2);
            studenti.Add("Lara", "Crofft");

            Console.WriteLine("\nIspis klase studenti koja nasljedjuje CollectionBase");
            foreach (var item in studenti)
            {
                Console.WriteLine("\n  ----> " + item.ToString());
=======

            Studenti studenti = new Studenti();
            studenti.Add(uc1);
            studenti.Add(uc2);
            studenti.Add("Lara","Crofft");


            Console.WriteLine("\nIspis klase studenti koja nasljedjuje collectionbase");
            foreach (var item in studenti)
            {
                Console.WriteLine("\n ------>" + item.ToString());
>>>>>>> 5aaecac3b02ef9522628931f10fd9ff44f09e710
            }

            // DODAJ vozače
            Vozac vo1 = new Vozac("Luka", "Krilić");  //Osoba()
            vo1.Kategorija_a = true;
            vo1.Kategorija_c = true;

            var a1 = new Automobil();
            a1.MarkaAutomobila = "Ford";

            var a2 = new Automobil();
            a2.MarkaAutomobila = "Mazda";

            vo1.Automobili.Add(a1);
            vo1.Automobili.Add(a2);

            Vozac vo2 = new Vozac("Niko", "Bulić");  //Osoba()
            vo2.Kategorija_b = true;
            vo2.Kategorija_d = true;


            List<Vozac> vozaci = new List<Vozac> { vo1, vo2 };

            foreach (var item in vozaci)
            {
                Console.WriteLine(item);
            }

            Pilot pi1= new Pilot("Ford", "Roks");  //Osoba()
            pi1.Kategorija_b = true;
            pi1.Kategorija_d = true;
            pi1.Kategorija_x = true;


            List<Pilot> piloti = new List<Pilot> { pi1};

            foreach (var item in piloti)
            {
                Console.WriteLine(item);
            }



            Console.ReadKey();
        }
    }
}
