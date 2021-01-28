using System;

namespace Primtal
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                try
                {
                
                    Console.WriteLine("\nWrite a number which will be the range all " +
                    "prime numbers will be shown within that range in the colour red");
                
                    int input = int.Parse(Console.ReadLine());
                
                    for (int a = 2; a < input; a++)
                    {
                        int prime = 0;
                        
                        for (int b = 1; b <a; b++)
                        {
                            if (a % b == 0)
                                
                                prime++;
                
                            if (prime == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine(a);
                                break;
                            }
                
                        }
                        
                        if (prime != 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(a);
                        }
                
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                   
                }
                
            }
            
        }
    }
}
