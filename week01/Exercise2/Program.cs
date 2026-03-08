using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade in percentage? ");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);
        string letter = "default";
        string extraString = "default";
        string sign = "default";
        int remainder = 5;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (grade >= 70)
        {
            extraString = "Congratulations! You have passed!";
        }
        else
        {
            extraString = "You have not passed, please try to study a little more next time";
        }
        if (!(grade > 93 || grade < 60))
        {
            remainder = grade%10;
            if (remainder >=7)
            {
                sign = "+";
            }
            else if (remainder <=3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        else
        {
            sign = "";
        }
        
        Console.WriteLine($"Your final grade is {letter}{sign}! {extraString}");
    }
}