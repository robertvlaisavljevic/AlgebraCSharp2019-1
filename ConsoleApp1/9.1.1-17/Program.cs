using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1._1_17
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string recenica = "Danas je suncan dan, zato vam Dobar dan!";
            string rijec = "dan";
            char slovo = 'n'; 
            

            int brojac = 0;
            for (int i = 0; i < recenica.Length; i++)
            {
                if (recenica [i]==slovo)
                {
                    brojac++;
                }
            }
            Console.WriteLine("9.1.1. ZNAK U RIJECI");
            Console.WriteLine("Znak '{0}' pojavljuje se u rijeci '{1}' {2} puta.", slovo, rijec, brojac);

            //recenica = recenica.ToLower();
            string[] nizrijeci = recenica.Split(' ', ',', '!');
            brojac = 0;
            for (int i = 0; i < nizrijeci.Length; i++)
            {
                if (nizrijeci[i].ToLower() == rijec.ToLower())
                {
                    brojac++;
                }
            }
            Console.WriteLine("\n9.1.2. RIJEC U RIJECI");
            Console.WriteLine("Rijec '{0}' pojavljuje se u recenici '{1}' {2} puta.", rijec, recenica, brojac);

            Console.WriteLine("\n9.1.3. RIJEC U NOVI RED");
            for (int i = 0; i < nizrijeci.Length; i++)
            {
                Console.WriteLine(nizrijeci[i]);
            }

            //nizrijeci.CopyTo
            nizrijeci = recenica.Split(' ');
            Console.WriteLine("\n9.1.4. BROJAC RIJECI U RECENICI");
            Console.WriteLine("Recenica '{0}' ima '{1}' rijeci.", recenica, nizrijeci.Length);



            Console.WriteLine("\n9.1.6. PALINDROM");
            Console.WriteLine("Unesite tekst: ");
            string tekst = Console.ReadLine();

            tekst = tekst.Replace(" ", "");
            string obrnuto = "";

            for (int i = tekst.Length -1; i >=0; i--)
            {
                obrnuto+=tekst[i];
            }
            if (tekst == obrnuto)
            {
                Console.WriteLine("To je PALINDROM");
            }
            else
            {
                Console.WriteLine("To NIJE palindrom");
            }

            Console.ReadKey();
        }
    }
}
