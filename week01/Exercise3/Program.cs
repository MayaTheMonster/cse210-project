using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        bool incorrect = true;
        string guess = "-3";
        int intGuess = -2;
        int guessCounter = 1;
        string answer = "default";
        bool quit = false;

        while (quit == false)
        {

            Random randomGenerator = new Random();
            int MagicNumber = randomGenerator.Next(1,100);

            while (incorrect == true)
            {
                Console.Write("What is the magic number? ");
                guess = Console.ReadLine();
                intGuess = int.Parse(guess);
                if (MagicNumber>intGuess)
                {
                    Console.WriteLine("Higher!");
                }
                else if (MagicNumber<intGuess)
                {
                    Console.WriteLine("Lower!");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {guessCounter} tries!");
                    incorrect = false;
                }
                guessCounter += 1;
            }
            Console.Write("Would you like to play again? ");
            answer = Console.ReadLine();
                if (answer == "yes")
                {
                    incorrect=true;
                }
                else
                {
                    quit=true;
                }
        

        }
    }
}