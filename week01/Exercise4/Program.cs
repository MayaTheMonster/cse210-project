using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string value = "0";
        int valueInt = 0;
        bool repeat = true;
        float total = 0;
        float quantity = 0;
        float average = 0;
        int largest = 0;
        int smallest = 9999;
        int num = 0;
        int bigSmallCount = 0;

        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (repeat == true)
        {
            Console.Write("Enter a number: ");
            value = Console.ReadLine();
            valueInt = int.Parse(value);
            if (valueInt == 0)
            {
                break;
            }
            else
            {
                numbers.Add(valueInt);
                total += valueInt;
                quantity += 1;
            }
        }

        average = total/quantity;
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");

        foreach (int number in numbers)
        {
            num = number;
            if (num > largest)
            {
                largest = num;
            }
            if (num < smallest && num > 0)
            {
                smallest = num;
            }
            else if (num >= smallest && smallest == 9999)
            {
                smallest = num;
                bigSmallCount=1;
            }
        }

        Console.WriteLine($"The largest number is: {largest}");
        if (smallest == 9999 && bigSmallCount == 0)
        {
            Console.WriteLine($"no positive number was inputed");
        }
        else
        {
            Console.WriteLine($"The smallest positive number is: {smallest}");
        }
        numbers.Sort();
        Console.WriteLine($"The sorted list is:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}