using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment one = new MathAssignment("Maya","C#","32","1-99");
        string homeworkList =  one.GetHomeworkList();
        Console.WriteLine(homeworkList);
        WritingAssignment two = new WritingAssignment("Not Maya","Lectures","My small little world");
        string otherHomework =  two.GetWritingInformation();
        Console.WriteLine();
        Console.WriteLine(otherHomework);
    }
}