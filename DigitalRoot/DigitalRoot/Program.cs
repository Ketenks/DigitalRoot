﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalRoot("");

            Console.ReadKey(); //keeps console open
        }
        static void DigitalRoot(string rootThis)
        {
             
             
            

                Console.WriteLine("Please enter any positive integer up to 17 digits: ");
                Console.WriteLine();
                rootThis = Console.ReadLine();
                long number = 0;
                bool isANumber = long.TryParse(rootThis, out number);
                Console.WriteLine();
            if(isANumber == true && rootThis.Length < 18 && !rootThis.Contains("-."))
            {
                long total = 0;
               

                    for (int i = 0; i < rootThis.Length; i++)
                    {
                        long number2 = long.Parse(rootThis[i].ToString());
                        total += number;
                    }
                    while (total.ToString().Length > 1)
                    {
                        for (int i = 0; i < total.ToString().Length; i++)
                        {
                            total = long.Parse(total.ToString()[i].ToString());
                        }
                    }

                    Console.WriteLine("Input: " + rootThis);
                    Console.WriteLine("Output: " + total);
                    Console.WriteLine();
                    DigitalRoot("");
            }
            else
            {
                DigitalRoot(""); 
            }
                

           
            

        }
    }
}
