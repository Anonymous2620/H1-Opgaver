using Engine;
using System;
using System.Threading;

namespace Terningkastet
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Random random = new Random();
                int Dice = random.Next(1, 6);


                Console.WriteLine("This is the game DICE. Press enter to start.");

                while (Input.KeyReleased(Key.RETURN) == false)
                    Thread.Sleep(100);

                Console.ForegroundColor = ConsoleColor.Red;
                if (Dice == 1)
                    Console.WriteLine("You rolled 1");

                Console.ForegroundColor = ConsoleColor.Blue;
                if (Dice == 2)
                    Console.WriteLine("You rolled 2");

                Console.ForegroundColor = ConsoleColor.Yellow;
                if (Dice == 3)
                    Console.WriteLine("You rolled 3");

                Console.ForegroundColor = ConsoleColor.Magenta;
                if (Dice == 4)
                    Console.WriteLine("You rolled 4");

                Console.ForegroundColor = ConsoleColor.Green;
                if (Dice == 5)
                    Console.WriteLine("You rolled 5");

                Console.ForegroundColor = ConsoleColor.Gray;
                if (Dice == 6)
                    Console.WriteLine("You rolled 6");


                Console.WriteLine("Press Enter to start a new round of Dice");

                while (Input.KeyReleased(Key.RETURN) == false)
                    Thread.Sleep(50);

                Console.Clear();
            }
        }
    }
}
