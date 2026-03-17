using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Fraction hello = new Fraction(3);
        string input = Console.ReadLine();
        int intInput = int.Parse(input);
        hello.GetBottom(intInput);
        string fracto = hello.GetFractionalString(); 
        Console.WriteLine(fracto);
        int top = hello.SetBottom();
        Console.WriteLine(top);
        double result = hello.GetDecimalValue();
        Console.WriteLine(result);
    }
}