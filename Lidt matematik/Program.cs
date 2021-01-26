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
                    Console.WriteLine("Input 2 integers and you will get answer in Adition, Division and Potency");


                    Console.WriteLine("Write integer one:");
                    int one = int.Parse(Console.ReadLine());


                    Console.WriteLine("Write integer two:");
                    int two = int.Parse(Console.ReadLine());

                    Console.WriteLine("The numbers plussed: " + (one + two));
                    Console.WriteLine("The numbers divided: \n" + (one / two));


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
