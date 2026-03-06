using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade in percentage? ");
        string GradeString = Console.ReadLine();
        int Grade = int.Parse(GradeString);
        string letter = "default";
        string ExtraString = "default";
        string Sign = "default";
        int remainder = 5;

        if (Grade >= 90)
        {
            letter = "A";
        }
        else if (Grade >= 80)
        {
            letter = "B";
        }
        else if (Grade >= 70)
        {
            letter = "C";
        }
        else if (Grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (Grade >= 70)
        {
            ExtraString = "Congratulations! You have passed!";
        }
        else
        {
            ExtraString = "You have not passed, please try to study a little more next time";
        }
        if (!(Grade > 93 || Grade < 60))
        {
            remainder = Grade%10;
            if (remainder >=7)
            {
                Sign = "+";
            }
            else if (remainder <=3)
            {
                Sign = "-";
            }
            else
            {
                Sign = "";
            }
        }
        else
        {
            Sign = "";
        }
        
        Console.WriteLine($"Your final grade is {letter}{Sign}! {ExtraString}");
    }
}