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

            if (userGuess == secretNum)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect.");
            }
        }
    }
}
