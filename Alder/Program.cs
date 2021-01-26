using System;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random random = new Random();
                int nothing = random.Next(3, 15);

                try
                {
                    Console.WriteLine("Enter your name to get startet");
                    string name = (Console.ReadLine());
                    Console.WriteLine("Now enter your age");
                    int age = int.Parse(Console.ReadLine());

                    Console.WriteLine("Name: " + name);
                    Console.WriteLine("Age: " + age);

                    if
                    (age < 3)
                        Console.WriteLine(name + ", du må gå med ble");

                    else if
                        (age >= 18)
                        Console.WriteLine(name + ", du må stemme og køre bil");

                    else if (age == 17)
                        Console.WriteLine(name + ", du må drikke");

                    else if (age == 16)
                        Console.WriteLine(name + ", du må drikke");

                    else if (age <= 15)
                        Console.WriteLine(name + ", du må ingenting");

                    else if (age >= 3)
                        Console.WriteLine(name + ", du må ingenting");


                }
                catch
                {
                    Console.WriteLine("INVALID INPUT!!!");
                    continue;

                }


            }
        }
    }
}