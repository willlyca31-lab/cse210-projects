using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine("\nJournal Menu");
            Console.WriteLine("1. Write New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal CSV");
            Console.WriteLine("4. Load Journal CSV");
            Console.WriteLine("5. Save Journal JSON");
            Console.WriteLine("6. Exit");

            Console.Write("Choose an option: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:

                    string prompt = promptGenerator.GetRandomPrompt();

                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("> ");

                    string response = Console.ReadLine();

                    string date = DateTime.Now.ToShortDateString();

                    Entry entry = new Entry(date, prompt, response);

                    journal.AddEntry(entry);

                    break;

                case 2:

                    journal.DisplayAll();

                    break;

                case 3:

                    Console.Write("CSV filename: ");
                    string csvFile = Console.ReadLine();

                    journal.SaveToCSV(csvFile);

                    Console.WriteLine("Journal saved to CSV.");

                    break;

                case 4:

                    Console.Write("CSV filename: ");
                    string loadCsv = Console.ReadLine();

                    journal.LoadFromCSV(loadCsv);

                    Console.WriteLine("Journal loaded from CSV.");

                    break;

                case 5:

                    Console.Write("JSON filename: ");
                    string jsonFile = Console.ReadLine();

                    journal.SaveToJSON(jsonFile);

                    Console.WriteLine("Journal saved to JSON.");

                    break;

                case 6:

                    Console.WriteLine("Goodbye!");

                    break;

                default:

                    Console.WriteLine("Invalid option.");

                    break;
            }
        }
    }
}