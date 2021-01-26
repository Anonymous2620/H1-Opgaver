using System;

namespace Gæt_et_tal
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            Console.WriteLine("This is the game Higher Or Lower. Enter a number to get startet.");
            int guess;
            int timesGuessed = 0;
            while (true)
            {
                
                try
                {
                    Console.Write("Your guess: ");
                    
                    guess = int.Parse(Console.ReadLine());
                    
                    if (guess > randomNumber)
                    {
                        Console.WriteLine("Too high, Lower!");
                        timesGuessed++;
                        Console.WriteLine("You have guessed: " + (timesGuessed) + " times");

                    }
                    
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine("Too low, Higher!");
                        timesGuessed++;
                        Console.WriteLine("You have guessed: " + (timesGuessed) + "times");
                    }

                    else if (guess == randomNumber)
                    {
                        Console.WriteLine("Perfect, Good job!. Press enter to star a new round");
                        timesGuessed++;
                        Console.WriteLine("You have guessed: " + (timesGuessed) + "times");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("This is the game Higher Or Lower. enter a number to get startet.");
                        randomNumber = random.Next(0, 100);
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input, Only numbers");
                    continue;
                }
               

            }
        }
    }
}
