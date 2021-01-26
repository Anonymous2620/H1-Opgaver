using System;

namespace Igang_med_løkker
{
    class Program
    {
        static void Main(string[] args)
        {
           
            try
            {




                for (int i = 0; i < 100; i++)
                {
                    //Denne if sætning går i gang hvis i er mindre end 50 hvilket den er fordi i er 0.
                    if (i < 50)
                        Console.WriteLine("\n" + i);
                }
                
                



                int c = 0;
                while (c < 50)
                {
                    Console.WriteLine("\n" + c);
                    c++;
                }
                
                



                for (int d = 100; d > -1; d--)
                {
                    Console.WriteLine("\n" + d);
                }

            }
            catch
            {
                Console.WriteLine("Invalid input");
                Console.ReadKey();
                Console.Clear();
                
            }
            
        }
    }
}
