﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._7_ispis
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                if(i%7==0 && i%3!=0)
                {
                    Console.WriteLine(" " + i);
                }
                
            }
            Console.ReadKey();
        }
    }
}
