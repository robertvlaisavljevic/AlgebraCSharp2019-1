using System;

namespace _8._3._1_Nasljeđivanje
{
    public abstract class Osoba
    {
        public DateTime datumNastanka;
        public Osoba{};
        public string prezime = "";
        private string ime = "";

        public string Ime
        {
            get => ime;
            set => ime = ToUpper.FirstCharToUpper(value);
        }

        {
            this.datumNastanka = DateTime.Now;
            Console.WriteLine("Pozvana metoda Osoba:Osoba()");
        }
    }
}