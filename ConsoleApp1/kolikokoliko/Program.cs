﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolikokoliko
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 0;
           Console.WriteLine("Brojevi koji su djeljivi sa 7 a nisu djeljivi sa 3 u intervalu od 1 do 1000 su: \n");
            for (int i = 1; i <= 1000; i++)
            {
                
                if (i%7==0 && (!(i % 3 == 0)))
                {
                    Console.Write("{0} ", i);
                    
                }

                
            }

            Console.WriteLine("\n\nUkupno ih ima: \n");
            for (int i = 1; i <= 1000; i++)
            {

                if (i % 7 == 0 && (!(i % 3 == 0)))
                {
                    b++;
                    
                }

                
            }
            Console.Write("{0} ", b);

            { 
            Console.WriteLine("\n\nBrojevi koji nisu djeljivi sa 3 su:\n ");
                for (int a = 1; a < 1000; a++)
                {
                    if (!(a%3==0))
                    {
                        Console.Write("{0} ", a);
                    }
                }
                
            }
            Console.WriteLine("\n\nUkupno ih ima: \n");
            for (int i = 1; i <= 1000; i++)
            {

                if (i%3 == 0)
                {
                    b++;

                }


            }
            Console.Write("{0} ", b);

            Console.ReadKey();

            
        }
    }
}


