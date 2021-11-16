using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Try to guess the random number!");
            Console.WriteLine("Difficulty (Easy, Medium, Hard, Cheater): ");
            string difficulty = Console.ReadLine().ToLower();

            switch (difficulty)
            {
                case "easy":
                    runFunc(8);
                    break;
                case "medium":
                    runFunc(6);
                    break;
                case "hard":
                    runFunc(4);
                    break;
                case "cheater":
                    runFuncInf();
                    break;
                default:
                    Console.WriteLine("Not an option. Default setting: Easy");
                    runFunc(8);
                    break;
            }

            void runFunc(int input)
            {
                try
                {
                    Random randInt = new Random();

                    int secretNum = randInt.Next(1, 100);

                    Console.Write("Input your guess: ");
                    int userGuess = int.Parse(Console.ReadLine());

                    for (int i = 0; i < input - 1; i++)
                    {

                        if (userGuess == secretNum)
                        {
                            Console.WriteLine("Correct!");
                            break;
                        }
                        else if (userGuess > secretNum)
                        {
                            Console.WriteLine("Incorrect. Guess too high");
                            Console.Write($"Try again ({input - (i + 1)} left!): ");
                            userGuess = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Incorrect. Guess too low");
                            Console.Write($"Try again ({input - (i + 1)} left!): ");
                            userGuess = int.Parse(Console.ReadLine());
                        }
                    };

                    if (userGuess == secretNum)
                    {
                        Console.WriteLine("Correct!");
                    }
                    else if (userGuess > secretNum)
                    {
                        Console.WriteLine("Incorrect. Guess too high");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect. Guess too high");
                    };
                }
                catch
                {
                    Console.WriteLine("Integers only please.");
                }

            }

            void runFuncInf()
            {
                Random randInt = new Random();

                int secretNum = randInt.Next(1, 100);

                Console.Write("Input your guess: ");
                int userGuess = int.Parse(Console.ReadLine());

                while (userGuess != secretNum)
                {
                    if (userGuess > secretNum)
                    {
                        Console.WriteLine("Incorrect. Guess too high");
                        Console.Write($"Try again: ");
                        userGuess = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Incorrect. Guess too low");
                        Console.Write($"Try again: ");
                        userGuess = int.Parse(Console.ReadLine());
                    }
                };

                Console.WriteLine("Correct!");


            }
        }
    }
}
