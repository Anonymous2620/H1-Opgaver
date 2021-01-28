using System;

namespace Arrays_og_bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numb = new int[100];
            Random random = new Random();

            //for (int a = 0; a < numb.Length; a++)
            //{
            //    int randomNumber = random.Next(0, 1000);

            //    numb[a] = randomNumber;

            //    Console.WriteLine(numb[a]);
            //}

            for (int b = 0; b <= numb.Length; b++)
            {
                for (int c = 0; c < (numb.Length-1) -b; b++)
                {
                    if (numb[c] < numb[c + 1])
                    {
                        int temp = numb[c + 1];
                        numb[c + 1] = numb[c];
                        numb[c] = temp;
                    }
                    Console.WriteLine(b);
                }
            }
            Console.ReadKey();
        }
    }
}
