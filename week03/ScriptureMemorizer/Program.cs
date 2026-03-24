//Reworked the code so the user can input their own scriptures without editing the code directly, also added the option for the user to "reset"
//the program to be able to see the full uncensored scripture again
using System;
using System.Net;
using System.Net.Quic;
using System.Resources;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        bool continuing = true;
        Scripture one = new Scripture();
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        List<string> groupList = one.SetScripture();
        one.ScriptureCountResetter();
        Console.WriteLine("Everything is ready, press enter to start.");
        Console.ReadLine();
        string message = "Press Enter to continue, type 'quit' to finish or type 'reset' to restart: ";
        string quit = "";
        if (groupList[0] == "1")
        {
            Reference initializer = new Reference(groupList[1],groupList[2],groupList[3]);
            while (continuing == true)
            {
                Console.Clear();
                initializer.DisplayReference();
                one.DisplayCurrentScriptures();
                Console.WriteLine();
                Console.WriteLine();
                Console.Write(message);
                quit = Console.ReadLine();
                if (quit == "quit")
                {
                    continuing = false;
                }
                else if (quit == "reset")
                {
                    one.ResetScriptureHider(groupList);
                }
                else
                {
                    message = one.HideWords();
                }
            }
        }
        else if (groupList[0] == "2")
        {
            Reference initializer = new Reference(groupList[1],groupList[2],groupList[3],groupList[4],groupList[5]);
            while (continuing == true)
            {
                Console.Clear();
                initializer.DisplayReference();
                one.DisplayCurrentScriptures();
                Console.WriteLine();
                Console.WriteLine();
                Console.Write(message);
                quit = Console.ReadLine();
                if (quit == "quit")
                {
                    continuing = false;
                }
                else if (quit == "reset")
                {
                    one.ResetScriptureHider(groupList);
                }
                else
                {
                    message = one.HideWords();
                }
            }
        }
        else
        {
            Reference initializer = new Reference(groupList[1],groupList[2],groupList[3],groupList[4],groupList[5],groupList[6],groupList[7]);
            while (continuing == true)
            {
                Console.Clear();
                initializer.DisplayReference();
                one.DisplayCurrentScriptures();
                Console.WriteLine();
                Console.WriteLine();
                Console.Write(message);
                quit = Console.ReadLine();
                if (quit == "quit")
                {
                    continuing = false;
                }
                else if (quit == "reset")
                {
                    one.ResetScriptureHider(groupList);
                }
                else
                {
                    message = one.HideWords();
                }
            }
        }
        Console.Clear();
        Console.WriteLine("Thank you for using our program");
    }
}