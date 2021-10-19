using System;
using System.Threading;

namespace monJustePrix
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bonjour et bienvenu dans la v1 de 'Find the number'!");

            var proposition = 0;
            var price = new Random().Next(100, 1001);       // define price to search between 100 & 1000
            
            Console.WriteLine("Vous devez trouver le nombre le plus vite possible. \nPrêt?");
            Console.WriteLine("Appuyer sur n'importe quelle touche...");
            
            while (Console.KeyAvailable == false)
                Thread.Sleep(100);
            
            Thread.Sleep(1000);
            Console.WriteLine("3");
            Thread.Sleep(1000);
            Console.WriteLine("2");
            Thread.Sleep(1000);
            Console.WriteLine("1");
            Thread.Sleep(1000);
            Console.WriteLine("Go!");
            
            Console.Write("Proposition : ");
            proposition = Console.Read();

            while (proposition != price)                            // while proposed price =! real price
            {
                
                if (proposition < 100 | proposition > 1000)         // if the proposed price isnt in the price range
                {
                    Console.WriteLine("Entrez un nombre entre 100 et 1000 : ");
                }
                else
                {
                    if (proposition < price)                            // if the price is higher than the proposed solution
                    {
                        Console.WriteLine("C'est plus!");
                    } 
            
                    if (proposition > price)                            // if the price is lower than the proposed solution
                    {
                        Console.WriteLine("C'est moins!");
                    }
                }

                Console.Write("Proposition : ");
                proposition = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.Beep();
            Console.WriteLine("Félicitation vous avez trouvé le juste prix!!");
            Console.WriteLine("Appuyer sur n'importe quelle touche pour quitter.");
            Console.ReadKey();
        }
    }
}
