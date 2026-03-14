// Added flavor text, made possible to add, save and load custom questions from a file.

using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Text;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        bool executing = true;
        bool secondTime = false;
        Diary diary = new Diary();
        Questions questions = new Questions();
        Console.WriteLine("Hello, what would you like to do this lovely day?");
        while (executing == true)
        {
            if (secondTime == true)
            {
                Console.WriteLine();
                Console.WriteLine("Anything else?");
            }
            Console.WriteLine("");
            Console.WriteLine("1- Write a new entry");
            Console.WriteLine("2- Display the journal");
            Console.WriteLine("3- Save journal to a file");
            Console.WriteLine("4- Load journal from a file");
            Console.WriteLine("5- Add a new prompt question");
            Console.WriteLine("6- Quit the program");
            string selection = Console.ReadLine();

            if (selection == "2")
            {
                Console.WriteLine();
                diary.ReadDiary();
            }
            else if (selection == "3")
            {
                Console.WriteLine("What should the file be called?");
                string fileName = Console.ReadLine();
                diary.SaveToFile(fileName);
                questions.SaveQuestions(fileName);
            }
            else if (selection == "4")
            {
                Console.WriteLine("What is the file name?");
                string loadedFileName = Console.ReadLine();
                diary.LoadFile(loadedFileName);
                questions.LoadQuestions(loadedFileName);
            }
            else if (selection == "5")
            {
                Console.WriteLine("What question would you like to add?");
                string addedQuestion = Console.ReadLine();
                questions.AddQuestion(addedQuestion);
            }
            else if (selection == "6")
            {
                executing = false;
            }
            else
            {
                Console.WriteLine();
                string todaysQuestion = questions.GenerateRandomQuestion();
                Console.WriteLine(todaysQuestion);
                Console.Write(">");
                string todaysEntry = Console.ReadLine();
                DateTime currentTime = DateTime.Now;
                string timeNow = currentTime.ToShortDateString();
                diary.AddEntry(todaysEntry,todaysQuestion,timeNow);
            }
            secondTime = true;
        }
        Console.WriteLine("Sleeping now");
    }   
}