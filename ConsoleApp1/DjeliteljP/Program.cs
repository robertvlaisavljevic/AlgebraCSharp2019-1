﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjeliteljP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 0;
                string odgovor = "";

                
                Console.Write("Upisite broj: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Svi brojevi djeljivi sa {0} su: ", a);
               
                    for (int i = 1; i <= a; i++)
                    {
                    if (a % i == 0)
                    {
                        Console.Write("{0} ", i);
                    }
                        
                    }
                    
                
            }
            catch (Exception broj)
            {
                Console.Write("GRESKA!", broj);
            }
            Console.ReadKey();
        
        }
    }
}
