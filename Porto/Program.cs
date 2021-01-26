using System;

namespace Porto
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Postnord Pakage Sending Price Calculator\nPakages need to have a minimum of 14 CM in length and a minimum of 9 CM in width.\n " +
                       
                        "Pakages have a max = Length + Width + Height = 300 cm " +
                       
                        "\nThe length sould not exceed 150 CM, and the weight is not allowed to be higher than 20 KG\nLetters need to have a minimum of 14 CM in length and a minimum of 9 CM in width.\n " +
                        
                        "Letters have a max = Length + Width + Height = 90 cm " +
                        
                        "\nThe length sould not exceed 60 CM, and the weight is not allowed to be higher than 20 KG\n");
                    
                   
                    Console.WriteLine("Enter Height = CM:");
                    double h = double.Parse(Console.ReadLine());
                   
                    Console.WriteLine("Length = CM:");
                    double l = double.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Width = CM:");
                    double w = double.Parse(Console.ReadLine());
                   
                    Console.WriteLine("Weight = KG:");
                    double we = double.Parse(Console.ReadLine());
                  
                    Console.WriteLine("Country:");
                    string c = (Console.ReadLine());

                    
                    double letter = 90;
                    
                    double pakage = 300;

                    if (l < 14)
                    {
                        Console.WriteLine("The Length is not big enough. Please choose a Length with a minimum of 14 CM.");

                    }

                    if (w < 9)
                    {
                        Console.WriteLine("The Width is not big enough. Please choose a Width with a minimum of 9 CM.");

                    }
                    if (l > 150)
                    {
                        Console.WriteLine("The Length shall not be longer than 150 CM. Please choose a lower Length");

                    }
                    if (we > 20)
                    {
                        Console.WriteLine("The Weight shall not be heavier than 20 KG. Please choose a lower Weight");

                    }


                    if (l + h + w <= letter)
                    {
                        Console.WriteLine("Perfect, the price for your letter is 11 DKK for standard shiping and 29 DKK for fast shiping.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Postnord Pakage Sending Price Calculator");
                    }

                    if (l + h + w <= pakage)
                    {
                        Console.WriteLine("Perfect, the price for your pakage is 50 DKK for standard shiping and 65 DKK for fast shiping.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Postnord Pakage Sending Price Calculator");
                    }
                    else if (l + h + w > pakage)
                        Console.WriteLine("Your pakage is too big and therefore not eligible for sendning through Postnord. " +
                            "Remember that leters have a max \nLength + Width + Height = 90 cm \nwhile Pakages have a max \nLength + Width + Height = 300 cm");


                }
                catch
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
            }
        }
    }
}
