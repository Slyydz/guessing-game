using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try to guess the random number!");
            Console.Write("Your guess: ");
            int userGuess = int.Parse(Console.ReadLine());
            Console.Write("Your guess: ");
            Console.WriteLine(userGuess);
        }
    }
}
