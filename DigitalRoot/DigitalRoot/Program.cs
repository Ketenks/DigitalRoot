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
             int number = 0;
             bool isANumber;
            do
            {

                Console.WriteLine("Please enter any positive integer: ");
                Console.WriteLine();
                rootThis = Console.ReadLine();
                
                 isANumber = int.TryParse(rootThis, out number);
                Console.WriteLine();
                int total = 0;
               

                    for (int i = 0; i < rootThis.Length; i++)
                    {
                        int number2 = int.Parse(rootThis[i].ToString());
                        total += number;
                    }
                    while (total.ToString().Length > 1)
                    {
                        for (int i = 0; i < total.ToString().Length; i++)
                        {
                            total = int.Parse(total.ToString()[i].ToString());
                        }
                    }

                    Console.WriteLine("Input: " + rootThis);
                    Console.WriteLine("Output: " + total);
                    Console.WriteLine();

                

           } while (isANumber == true);
            

        }
    }
}
