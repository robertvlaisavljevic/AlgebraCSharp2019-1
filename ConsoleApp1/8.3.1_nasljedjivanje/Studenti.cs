using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _8._3._1_nasljedjivanje
{
<<<<<<< HEAD
    public class Studenti:System.Collections.CollectionBase
    {

=======
    public class Studenti: System.Collections.CollectionBase
    {
>>>>>>> 5aaecac3b02ef9522628931f10fd9ff44f09e710
        public int Add(object uc)
        {
            return base.InnerList.Add(uc);
        }
        public int Add(string ime, string prezime)
        {
            Ucenik uc = new Ucenik(ime, prezime);
            return base.InnerList.Add(uc);
        }
        public object this[int index]
        {
            get
            {
                return (Ucenik)base.InnerList[index];
            }
        }
    }
}
