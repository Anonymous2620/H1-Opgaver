using System;

namespace Lot
{
    class Program
    {
        static void Main(string[] args)
        {     
            int[] ticket = new int[6];

            
           
            int[] myCoupon = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            
            
            int numbersMatch = 0;

            
            Random r = new Random(Guid.NewGuid().GetHashCode());

            
            Console.WriteLine("You got a lucky cupon!");
            
            
            for (int i = 0; i < ticket.Length; i++)
            {
                
                ticket[i] = r.Next(1, 20);
                
                
                Console.WriteLine(i + 1 + " " + ticket[i]);

            }

            for (int i = 0; i < ticket.Length; i++)
            {
                
                foreach (int num in myCoupon)
                {
                    
                    if (ticket[i] == num)
                    {
                        
                        numbersMatch++;
                        break;
                    
                    }
                }
            }
            
            checkWin(numbersMatch);
            
            Console.ReadKey();
        
        }

        static void checkWin(int macthingNumbers)
        
        {
           
            switch (macthingNumbers)
            {
                case 0:
                    Console.WriteLine("\nYou had a lucky ticket but never a prize");
                    break;

                case 1:
                    Console.WriteLine("\nYour prize is 350 DKK");
                    break;

                case 2:
                    Console.WriteLine("\nYour prize is 700 DKK");
                    break;

                case 3:
                    Console.WriteLine("\nYour prize is 2.800 DKK");
                    break;

                case 4:
                    Console.WriteLine("\nYour prize is 22.400 DKK");
                    break;

                case 5:
                    Console.WriteLine("\nYour prize is 358.400 DKK");
                    break;

                case 6:
                    Console.WriteLine("\nYour prize is 11.468.800 DKK");
                    break;

                case 7:
                    Console.WriteLine("\nYour prize is 734.003.200 DKK");
                    break;
            } 


        }
    }
}
