using System;

class Program
{
    static void Main(string[] args)
    {
        static void SayHello()
        {
            Console.WriteLine("Welcome to the Program");
        }
        
        static string AskName()
        {
            Console.Write("Please enter your name: ");
            string nameUser = Console.ReadLine();
            return nameUser;
        }

        static int AskWholeNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string Numb1 = Console.ReadLine();
            int numb2 = int.Parse(Numb1);
            return numb2;
        }

        static int SquareNumber(int number)
        {
            int square = number*number;
            return square;
        }
        
        static void DisplaySquareName(string name, int square)
        {
            Console.WriteLine($"Brother {name}, the square of your number is {square}");
        }
        
        SayHello();
        string username = AskName();
        int favoriteNumber = AskWholeNumber();
        int squaredFavorite = SquareNumber(favoriteNumber);
        DisplaySquareName(username,squaredFavorite);
    }
}