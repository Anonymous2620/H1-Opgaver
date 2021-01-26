using System;

namespace Valutaomregner
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Start by typing the number you want converted. You can convert DKK to 4 different types of currencies. = USD, GBP, EURO and SEK");
                try
                {
                    double DKK = double.Parse(Console.ReadLine());
                    //Her gør jeg så det man sætter ind i konsolen bliver værdien af DKK.
                    double USD = DKK * 0.16;
                    double GBP = DKK * 0.12;
                    double EURO = DKK * 0.13;
                    double SEK = DKK * 1.39;
                    //Her bliver værdien som man indtaster ganget med de forskellige tal.
                    Console.WriteLine("DKK to USD: " + USD);
                    Console.WriteLine("DKK to GBP: " + GBP);
                    Console.WriteLine("DKK to EURO: " + EURO);
                    Console.WriteLine("DKK to SEK: " + SEK);
                    //Her får man svar på omregningerne af valuta.

                }
                catch
                {
                    Console.WriteLine("Invalid input");
                    Console.Clear();
                    continue;
                }
                //Jeg har lavet en try and catch fordi på den måde ryger man ikke ud når man indtaster noget forkert.
            }
        }
    }
}
