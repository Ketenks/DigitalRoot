using System;
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
            do {

                Console.WriteLine("Please enter any positive integer: ");
                Console.WriteLine();
                rootThis = Console.ReadLine();
                Console.WriteLine();
                int total = 0;
                
                for (int i = 0; i < rootThis.Length; i++)
                {
                    int number = int.Parse(rootThis[i].ToString());
                     total += number;
                }
                while (total.ToString().Length > 1)
                {
                    for (int i = 0; i < total.ToString().Length; i++)
                    {
                        total =  int.Parse(total.ToString()[i].ToString());
                    }
                }

                Console.WriteLine("Input: " + rootThis);
                Console.WriteLine("Output: " + total);
                Console.WriteLine();



            }while("0123456789".Contains(rootThis) && !rootThis.Contains(".") || !rootThis.Contains("-"));


        }
    }
}
