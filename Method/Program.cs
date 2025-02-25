using System;

class Method(){

    public static void Details(){
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Welcome to the F-Calc!");
        Console.WriteLine();

        Console.WriteLine("1 for addition.");
        Console.WriteLine("2 for substraction.");
        Console.WriteLine("3 for multiplication.");
        Console.WriteLine("4 for division.");
        Console.WriteLine("5 for mod.");
        Console.WriteLine("0 for exit.");
        Console.WriteLine("-----------------------------------");
    }

    public static void add(){
        int a, b;
        Console.Write("Enter 1st number: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 2nd number: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine($"{a} + {b} = {a + b}");
    }

    public static void sub(){
        int a, b;
        Console.Write("Enter 1st number: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 2nd number: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine($"{a} - {b} = {a - b}");
    }

    public static void mul(){
        int a, b;
        Console.Write("Enter 1st number: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 2nd number: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine($"{a} x {b} = {a * b}");
    }

    public static void div(){
        int a, b;
        Console.Write("Enter 1st number: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 2nd number: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine($"{a} / {b} = {a / b}");
    }

    public static void mod(){
        int a, b;
        Console.Write("Enter 1st number: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 2nd number: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine($"{a} % {b} = {a % b}");
    }


    public static void Main(string[] args){
        while(true){
            Details();
            int choice;
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch(choice){
                case 0:
                    return;
                case 1:
                    add();
                    break;
                case 2:
                    sub();
                    break;
                case 3:
                    mul();
                    break;
                case 4: 
                    div();
                    break;
                case 5:
                    mod();
                    break;
                default:
                    Console.WriteLine("Invalid Input!!!");
                    break;
                
            }
            
        }

    }
}