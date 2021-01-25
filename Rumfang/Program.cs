using System;

namespace Rumfang
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Automatic Volume calculator for a box");
                    //Her er titlen som man ser når man åbner programmet.

                    Console.WriteLine("Height:");
                    double h = double.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Length:");
                    double l = double.Parse(Console.ReadLine());
                   
                    Console.WriteLine("Width:");
                    double w = double.Parse(Console.ReadLine());
                    //Her får jeg input fra konsolen og bruger det nedeunder for at regne resultatet ud.

                    Console.WriteLine("Volume of your box is: " + h * l * w);
                    //Her ligger jeg længde, brede og højte sammen.
                }
                catch
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                //Her laver en try and catch for at gøre det mulligt at skrive bogstaver med en fejl og starte igen istedet for at konsolen crasher.
            }
        }
    }
}
