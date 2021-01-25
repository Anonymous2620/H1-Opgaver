using System;

namespace Celciusomregner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Celcius omregner. Skriv antallet af Celcius du vil omregne  til Reamur og Fahrenheit");
            //Her skriver jeg en besked som man kan se når man køre programmet.

            double Celcius = double.Parse(Console.ReadLine());
            //Her gør jeg sådan så den værdi jeg skriver i konsolen bliver til Celcius.

            double Reamur = Celcius * 0.8;
            double Fahrenheit = Celcius * 1.8 + 32;
            //Her har jeg gjort så det tal jeg skrive ri konsolen bliver ganget og plusset med.

            Console.WriteLine("I Reamur\n" + Reamur);
            Console.WriteLine("I Fahrenheit\n" + Fahrenheit);
            //Her har jeg gjort så man kan se det endelige resultat i konsolen.

            Console.ReadKey();
            //Her har jeg gjort så man kan trykke enter for at kunne afslutte programmet.
        }
    }
}
