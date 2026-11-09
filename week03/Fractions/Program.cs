using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);

        Console.WriteLine("Original Values:");
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction3.GetFractionString());

        fraction3.SetTop(1);
        fraction3.SetBottom(3);

        Console.WriteLine("\nAfter using setters:");
        Console.WriteLine("Top: " + fraction3.GetTop());
        Console.WriteLine("Bottom: " + fraction3.GetBottom());

        Console.WriteLine("\nFraction representations:");

        Fraction one = new Fraction();
        Fraction five = new Fraction(5);
        Fraction threeFourths = new Fraction(3, 4);
        Fraction oneThird = new Fraction(1, 3);

        Console.WriteLine($"{one.GetFractionString()} = {one.GetDecimalValue()}");
        Console.WriteLine($"{five.GetFractionString()} = {five.GetDecimalValue()}");
        Console.WriteLine($"{threeFourths.GetFractionString()} = {threeFourths.GetDecimalValue()}");
        Console.WriteLine($"{oneThird.GetFractionString()} = {oneThird.GetDecimalValue()}");
    }
}