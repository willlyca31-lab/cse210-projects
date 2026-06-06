using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";

        _description =
            "This activity will help you relax by guiding you through slow breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            ExpandBreath();

            Console.WriteLine();

            Console.WriteLine("Breathe Out");

            ShowCountDown(5);

            Console.Clear();
        }

        DisplayEndingMessage();
    }

    public void ExpandBreath()
    {
        Console.Clear();

        Console.WriteLine("Breathe In");

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(new string('*', i * 2));

            Thread.Sleep(500);
        }
    }
}