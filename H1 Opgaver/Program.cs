using System;

namespace Variabler_og_datatyper
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 16;
            double b = 5.1;
            
            //int c = a + b;
            //Dette virker ikke da jeg prøver at få en int til at bruge en double værdi hvilket ikke er muligt siden int kun er til heltal.
            
            double d = a + b;
            //Dette virker fordi en double kan både vise heltal samt decimaltal.
            
            Console.WriteLine(d);
        }
    }
}
