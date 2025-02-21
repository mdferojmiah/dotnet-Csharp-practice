using System;

class Program{
    public static void Main(string[] args){
        // here question mark indicates that variable can contain null values
        string? studentName;
        string? studentAge;
        Console.Write("Enter your name: ");
        studentName = Console.ReadLine();
        
        Console.Write("Enter your age: ");
        studentAge = Console.ReadLine();

        //TryParse() method tries to convert the studentAge to integer and return the boolean value.
        //similar method is Parse(). Parse method thows exception if the data type and parsed data type is not similar.
        //TryParse() do not throw any exception.
        bool isSuccess = int.TryParse(studentAge, out int stuAge);

        if (isSuccess){
            Console.WriteLine($"Student name is {studentName}");
            Console.WriteLine($"Student age is {stuAge}");
        } else{
            Console.WriteLine("Wrong input format!!!");
        }

    }
}