using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string answer = Console.ReadLine();
            number = int.Parse(answer);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum of the numbers is: {sum}");

        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}");
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The maximum number is: {max}");
    }
}