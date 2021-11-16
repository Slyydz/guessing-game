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
            int secretNum = 42;


            for (int i = 0; i < 3; i++)
            {
                if (userGuess == secretNum)
                {
                    Console.WriteLine("Correct!");
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                    Console.Write("Try again: ");
                    userGuess = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
