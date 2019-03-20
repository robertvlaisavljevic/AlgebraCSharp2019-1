namespace z3
{
    internal class Automobil
    {
        public string Naziv = "";
        public int GodinaProizvodnje = 0;
        public double OsnovnaCijena = 0;
        public int TekucaGodina = 2019;
        public int Starost()
        {

            return TekucaGodina - GodinaProizvodnje;
        }
        public double UkupnaCijena()
        {
            double ratio = 0;

            if (OsnovnaCijena <= 7000)
            {
                ratio = 1.3;
            }
            else if (OsnovnaCijena < 10000 || OsnovnaCijena >7000)
            {
                ratio = 1.4;
            }
            else
            {
                ratio= 1.5;
            }
            return OsnovnaCijena * ratio;
        }
    }
}