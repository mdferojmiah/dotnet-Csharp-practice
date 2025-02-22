using System;

class Program{
    public static void Main(string[] args){
        Console.Write("Enter 1st number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 2nd number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 3rd number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2 + num3;
        double avg = sum / 3.0;

        Console.WriteLine($"The sum of {num1}, {num2} and {num3} is {sum}.");
        Console.WriteLine("The average of {0}, {1} and {2} is {3}.", num1, num2, num3, avg.ToString("F3"));

        Console.WriteLine();

        double celcius, farenheight;

        Console.Write("Celcius: ");
        celcius = Convert.ToDouble(Console.ReadLine());

        farenheight = 1.8*celcius + 32;

        Console.WriteLine($"Farenheight: {farenheight:F2} degree farenheight.");
    }
}