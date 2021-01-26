using System;

namespace Lidt_matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("\nInput 2 integers and you will get answer in Adition, Division and Potency");


                    Console.WriteLine("Write integer one:");
                    int one = int.Parse(Console.ReadLine());


                    Console.WriteLine("Write integer two:");
                    int two = int.Parse(Console.ReadLine());

                    Console.WriteLine("The integers plussed: " + (one + two));
                    
                    Console.WriteLine("\nThe integers divided: " + (one / two));

                    Console.WriteLine("\nInteger 1 raised in integer 2: " + (Math.Pow(one, two)));

                }
                catch
                {
                    Console.WriteLine("Invalid input");
                    Console.Clear();
                    continue;
                }
            }
        }
    }
}
