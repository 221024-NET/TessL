using System;
using System.Text;

namespace GameCollection.CoinFlipper
{
    public class Flipper
    {
        // Fields
        public int test = 0;

        // Constructor
        public Flipper() { }

        // Methods
        //[access modifier] [modifier] [return type] [method name] ([parameters])
        public void Play()
        {
            bool loop = true;
            while (loop)
            {
                CoinFlip(); // models the ENTIRE behavior

                Console.WriteLine("Would you like to flip more coins?");
                Console.WriteLine("Enter 'y' or 'Y' to run again, or anything else to exit:");
                string playAgain = Console.ReadLine().ToUpper();

                if (playAgain.Equals("Y"))
                {
                    loop = true;
                }
                else
                {
                    loop = false;
                }
            }
        }

        public void CoinFlip()
        {
            Console.WriteLine("Starting Coin Flipper:");

            Console.WriteLine("Enter the number of coins to flip: ");

            string UserNumber = Console.ReadLine();
            int Num = 0;

            try
            {
                Num = Int32.Parse(UserNumber);
                if (Num <= 0)
                {
                    throw new Exception("Argument may not be negative");
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("A less specific catch: " + e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("The least specific catch: " + e.Message);
            }

            Console.WriteLine(Flip(Num));
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        //[access modifier] [modifier] [return type] [method name] ([parameters])
        public string Flip(int Num)
        {
            StringBuilder sb = new StringBuilder();
            var rand = new Random();

            for (int i = 0; i < Num; i++)
            {
                int coin = rand.Next(2);
                sb.AppendLine(HoT(coin));
            }
            return sb.ToString();
        }

        public string HoT(int coin)
        {
            if (coin == 0)
            {
                return "Heads";
            }
            else
            {
                return "Tails";
            }
        }
    }
}