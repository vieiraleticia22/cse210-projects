using System;
using System.Collections.Generic;
public class ReflectionActivity : Activity
{
    public ReflectionActivity()
        : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }


    private List<string> _prompts = new List<string>
{
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
};


    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };


    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        List<string> availablePrompts = new List<string>(_prompts);  // Exceeding Requirements
        List<string> availableQuestions = new List<string>(_questions);    // Exceeding Requirements

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        int index = random.Next(availablePrompts.Count);

        string prompt = availablePrompts[index];  // Exceeding Requirements

        availablePrompts.RemoveAt(index);  // Exceeding Requirements

        Console.WriteLine(prompt);

        Console.WriteLine();
        Console.Write("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {

            if (availableQuestions.Count == 0)    // Exceeding Requirements
            {
                availableQuestions = new List<string>(_questions);
            }

            int questionIndex = random.Next(availableQuestions.Count);   // Exceeding Requirements

            string question = availableQuestions[questionIndex];

            availableQuestions.RemoveAt(questionIndex);

            Console.WriteLine();
            Console.WriteLine(question);

            ShowSpinner(5);
        }

        DisplayEndingMessage();
        ShowSpinner(3);
    }


}

