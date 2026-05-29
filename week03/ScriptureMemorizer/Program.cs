using System;
using System.Collections.Generic;
using ScriptureMemorizer;
using Microsoft.VisualBasic;
class Program
{
    static void Main(Strings[] args)
    {
        Reference reference = new Reference("Psalm", 119, 11);

        Scripture scripture = new Scripture(
            reference,
            "Thy word have I hid in mine heart that I might not sin against thee."
        );

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to finish: ");

            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Program ended.");
    }
}

