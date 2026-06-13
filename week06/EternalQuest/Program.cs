using System;

class Program
{
    static void Main()
    {
        GoalManager manager =
            new GoalManager();

        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Display Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Load");
            Console.WriteLine("7. Quit");

            int choice =
                int.Parse(Console.ReadLine());

            if (choice == 1)
                manager.CreateGoal();

            else if (choice == 2)
                manager.DisplayGoals();

            else if (choice == 3)
                manager.RecordEvent();

            else if (choice == 4)
                manager.DisplayScore();

            else if (choice == 5)
                manager.SaveGoals();

            else if (choice == 6)
                manager.LoadGoals();

            else if (choice == 7)
                running = false;
        }
    }
}