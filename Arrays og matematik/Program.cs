using System;
using System.Linq;

namespace Arrays_og_matematik
{
    class Program
    {  static void Main(string[] args)
        {
            try
            {

            int[] ListB = new int[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            
            
            int temp = 0; 
            
            
            for (int a = 0; a < ListB.Length; a++)
            {
                
                temp++;

                
                
                if (temp == 3)
                {
                    ListB = ListB.Where(d => d != ListB[a]).ToArray();
                    
                    temp = 1;
                }
            }
            
            ListB[2] = 17;

           
            int[] ListC = new int[20];

           
            ListB.CopyTo(ListC, 1);

            
            ListC = ListC.Where(d => d != ListC[0]).ToArray();
            
           
            Array.Reverse(ListC);

            
            Console.Write("\nList B Normal:   ");
            
            foreach (int a in ListB)
            
            {
                Console.Write(a + "  ");
            }

            Console.Write("\nList C Reversed: ");
            
            foreach (int a in ListC)
            
            {
                Console.Write(a + "  ");
            }

            }
            catch
            {
                Console.ReadLine();
            }
        }
    }
}
