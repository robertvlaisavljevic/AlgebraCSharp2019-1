﻿using System;
namespace _8._5._1_Primjer
{
    public class Osoba
    {
        //Deklaracija dogadjaja

        public delegate void NaPromjenuImenaDelegat(object sender, EventArgs e);
        public event NaPromjenuImenaDelegat NaPromjenuImena;

        //Svojstva
        private string ime;
        public string Ime
        {
            get { return ime;}
            set
            {
                ime = value;
                if (NaPromjenuImena != null)
                {
                    NaPromjenuImena(this, new EventArgs());
                }
            }
        }
    }
}