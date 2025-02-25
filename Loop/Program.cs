using System;

class Looping{
    public static void Main(string[] args){
        //Factorial();
        //Multiplication();
        Multi();
    }


    static void Factorial(){
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int fact = 1;

        for(int i = 1; i <= number; i++){
            fact *= i;
        }

        Console.WriteLine(fact);
    }


    static void Multiplication(){
        Console.Write("Enter a number: ");
        int input = Convert.ToInt32(Console.ReadLine());

        for(int i = 1; i <= 10; i++){
            Console.WriteLine($"{input} x {i} = {input*i}");
        }
    }

    static void Multi(){
        Console.Write("Start: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("End: ");
        int end = Convert.ToInt32(Console.ReadLine());

        for(int i = start; i <= end; i++){
            for(int j = 1; j <= 10; j++){
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
            Console.WriteLine();
        }
    }
}