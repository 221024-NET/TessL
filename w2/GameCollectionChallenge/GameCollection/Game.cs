using GameCollection.CoinFlipper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using GameCollection.CoinFlipper;
using GameCollection.Guessing;

namespace GameCollection.App
{
    public class Game
    {
        // Fields

        // Constructors
        public Game() { }

        // Methods
        public void run()
        {
            string selection;
            int choice;

            Console.WriteLine("Welcome to the Game Collection!");
            do
            {
                do
                {
                    Console.WriteLine(this.MainMenu());
                } while (!Int32.TryParse(Console.ReadLine(), out choice));

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Thanks for playing!");
                        return;

                    case 1:
                        Flipper flip = new Flipper();
                        flip.CoinFlip();
                        break;

                    case 2:
                        Guess guess = new Guess();
                        guess.Play();
                        break;
                }
                Console.Clear();
            } while (choice != 0);
            
        }

        public string MainMenu()
        {
            string menu = "Please select the game you would like to play: \n[0] - Exit \n[1] - Flip a coin \n[2] - Guessing game";
            return menu;
        }
    }
}
