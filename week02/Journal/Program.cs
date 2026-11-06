using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();

        List<string> prompts = new List<string>
        {
            "What was the best part of your day?",
            "What did you learn today?",
            "What are you grateful for today?",
            "What challenges did you face today?",
            "What made you smile today?",
            "How did I see the hand of the Lord in my life today?"
        };

        Random random = new Random();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");


            string userInput = Console.ReadLine();



            if (!int.TryParse(userInput, out choice))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }



            if (choice == 1)
            {
                int index = random.Next(prompts.Count);
                string prompt = prompts[index];

                Console.WriteLine(prompt);
                Console.Write("> ");

                string response = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                // Prompt the user for their mood EXEEDING REQUIREMENTS

                Console.WriteLine("How are you feeling today?");
                Console.WriteLine("1. Happy");
                Console.WriteLine("2. Sad");
                Console.WriteLine("3. Excited");
                Console.WriteLine("4. Anxious");
                Console.WriteLine("5. Grateful");
                Console.WriteLine("6. Tired");

                Console.Write("Choose your mood: ");
                string moodChoice = Console.ReadLine();

                string mood = moodChoice switch
                {
                    "1" => "Happy",
                    "2" => "Sad",
                    "3" => "Excited",
                    "4" => "Anxious",
                    "5" => "Grateful",
                    "6" => "Tired",
                    _ => "Not specified"
                };


                Entry entry = new Entry();

                entry._date = date;
                entry._promptText = prompt;
                entry._entryText = response;
                entry._mood = mood;

                journal.AddEntry(entry);

                Console.WriteLine("Your entry has been added to the journal.");
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter the file name: ");
                string fileName = Console.ReadLine();

                journal.LoadFromFile(fileName);
            }
            else if (choice == 4)
            {
                Console.Write("Enter the file name: ");
                string fileName = Console.ReadLine();

                journal.SaveToFile(fileName);
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}
