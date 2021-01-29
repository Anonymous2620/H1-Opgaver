using System;
using System.Media;


namespace Mozart
{
    class Program
    {
        static SoundPlayer soundPlayer = new SoundPlayer();

        static void Main(string[] args)
        {

            theMinuet();

            theTrio();

        }
        static void theMinuet()
        {


            string path = @"C:\Users\Simranjit Singh\Music\Wave\M";


            string[] musicelemnt = new string[177];


            for (int a = 1; a < musicelemnt.Length; a++)
            {
                musicelemnt[a] = path + a + ".wav";


                Console.WriteLine(musicelemnt[a]);


                soundPlayer.SoundLocation = musicelemnt[a];

                
                soundPlayer.Load();

                
                soundPlayer.PlaySync();
            }
        }

        static void theTrio()
        {


            string path = @"C:\Users\Simranjit Singh\Music\Wave\T";


            string[] musicelemnt = new string[97];

            for (int b = 1; b < musicelemnt.Length; b++)
            {

                musicelemnt[b] = path + b + ".wav";


                Console.WriteLine(musicelemnt[b]);


                soundPlayer.SoundLocation = musicelemnt[b];

                
                soundPlayer.Load();


                soundPlayer.PlaySync();
            }

            Console.ReadKey();
        }
    }
    
}
