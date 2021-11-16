using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try to guess the random number!");
            Console.Write("Input your guess: ");
            int userGuess = int.Parse(Console.ReadLine());
            Random randInt = new Random();

            int secretNum = randInt.Next(1, 100);


            for (int i = 1; i <= 3; i++)
            {
                if (userGuess == secretNum)
                {
                    Console.WriteLine("Correct!");
                    System.Environment.Exit(0);
                }
                else if (userGuess > secretNum)
                {
                    Console.WriteLine("Incorrect. Guess too high");
                    Console.Write($"Try again ({4 - (i)} left!): ");
                    userGuess = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Incorrect. Guess too low");
                    Console.Write($"Try again ({4 - (i)} left!): ");
                    userGuess = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
