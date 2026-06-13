using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        int choice = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }

        else if (choice == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }

        else if (choice == 3)
        {
            Console.Write("Target Count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(
                new ChecklistGoal(
                    name,
                    description,
                    points,
                    target,
                    bonus));
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void RecordEvent()
    {
        DisplayGoals();

        Console.Write("Choose goal: ");
        int choice = int.Parse(Console.ReadLine());

        int earnedPoints =
            _goals[choice - 1].RecordEvent();

        _score += earnedPoints;

        Console.WriteLine($"You earned {earnedPoints} points.");
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void SaveGoals()
    {
        using (StreamWriter output =
               new StreamWriter("goals.txt"))
        {
            output.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                output.WriteLine(
                    goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        string[] lines =
            File.ReadAllLines("goals.txt");

        _score = int.Parse(lines[0]);

        Console.WriteLine("Goals loaded.");
    }
}