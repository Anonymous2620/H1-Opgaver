using System;

namespace Pyhtagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {

                    Console.WriteLine("\nPythagoras calculator.");
                    Console.WriteLine("\nWrite a^2:");
                    double a2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("\nWrite b^2:");
                    double b2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nc^2 is: : " + (a2 * a2 + b2 * b2));

                    if (a2 > b2)
                    {
                        Console.WriteLine("\na^2 is the bigger number");

                    }
                    else if (a2 < b2)
                    {
                        Console.WriteLine("\nb^2 is the bigger number");

                    }
                    else
                    {
                        Console.WriteLine("\nBoth a^2 and b^2 is the same number");
                    }


                }
                catch
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

            }

        }
    }
}


