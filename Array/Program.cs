using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {

            int[] nultilni = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(nultilni[4]);

            nultilni[4] = 10;


            Console.WriteLine(nultilni[4]);

            }
            catch
            {
                Console.ReadKey();
                
                
            } 
        
        }
    }
}
