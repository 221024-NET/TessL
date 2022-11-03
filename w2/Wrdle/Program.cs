using System;
using System.IO;

namespace Wrdle
{
    class Program
    {
        static string statsPath = "./stats.txt";
        static string wordsPath = "./words.txt";

        static void Main()
        {
            File.WriteAllLines(wordsPath, new string[] {"words","break","chart","fifth","morel"});

            
            while (true)
            {
                Console.WriteLine("(A)dd more words, (P)lay, (C)hange/add user, (V)iew stats, or (Q)uit");

                //UNFINISHED ..... should move this to a thingy..method
                string option = "q";
                while (true)
                {
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.Enter) break;
                    else if (key == ConsoleKey.A)
                    {
                        Console.Write("\rAdd more words?       ");
                        option = "w";
                    }
                    else if (key == ConsoleKey.P) 
                    {
                        Console.Write("\rPlay?                 ");
                        option = "p";
                    }
                    else if (key == ConsoleKey.C) 
                    {
                        Console.Write("\rChange or add user?   ");
                        option = "c";
                    }
                    else if (key == ConsoleKey.V) 
                    {
                        Console.Write("\rView Stats?           ");
                        option = "v";
                    }
                    else if (key == ConsoleKey.Q) 
                    {
                        Console.Write("\rQuit?                 ");
                        option = "q";
                    }
                }



                // string option = Console.ReadLine();
                if (option.ToLower().Equals("a")) 
                { 
                    addWords();
                }
                else if (option.ToLower().Equals("p"))
                {
                    play();
                }
                else if (option.ToLower().Equals("c"))
                {
                    changeUser();
                }
                else if (option.ToLower().Equals("v"))
                {
                    viewStats();
                }
                else { break; }
            }
        }

        static void play() 
        {
            string[] words = File.ReadAllLines(wordsPath);

            int wordchoice = new Random().Next(words.Length);
            string goal = words[wordchoice];
            string guess = "";
            int guessesUsed=0;


            while (!guess.Equals(goal)) 
            {
                guessesUsed++;
                Console.WriteLine("Enter a 5 letter Guess:");
                guess = Console.ReadLine();

                for (int i=0; i < goal.Length; i++) 
                {
                    if (guess[i].Equals(goal[i]))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (goal.Contains(guess[i]))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else 
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write(guess[i]);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Console.WriteLine("Correct!");

            File.AppendAllText(statsPath, $"Took {guessesUsed} guess(es) to get {goal}\n");
        }
        static void changeUser()
        {
            Console.WriteLine("Enter your username:");
            string username = Console.ReadLine();
            //we r ignoring any bad characters. (add this as regex? i do not want to have more time)
            statsPath = "./stats" + username + ".txt";

        }
        static void addWords()
        {
            string newword;
            while (true)
            {
                Console.WriteLine("Enter a 5 letter word:");
                newword = Console.ReadLine();
                if (newword.Length==5) { File.AppendAllText(wordsPath, (string) newword + "\n"); }
                else { break; }
            }
        }
        static void viewStats()
        {
            foreach (string s in File.ReadAllLines(statsPath))
            {
                Console.WriteLine(s);
            }
        }
    
    
    
    }
}