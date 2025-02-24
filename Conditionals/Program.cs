using System;

class Program{
    public static void Main(string[] args){
        //LeapYear();
        //Switching();
        //weekday();
        //Shorthand();
        //SwitchType();
        SwtichCondition();
    }

    static void LeapYear(){
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0)){
            Console.WriteLine($"{year} is a leap year!");
        }else {
            Console.WriteLine($"{year} is not a leap year!");
        }
    }

    static void Switching(){
        char ch;

        Console.Write("Enter a Character: ");
        ch = Convert.ToChar(Console.ReadLine());

        switch(Char.ToLower(ch)){
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine($"{ch} is a vowel.");
                break;
            default:
                if(char.IsLetter(ch)){
                    Console.WriteLine($"{ch} is a consonant.");
                }else {
                    Console.WriteLine($"{ch} is not a valid input.");
                }
                break;
        }
    }


    static void weekday(){
        string input;

        Console.Write("Enter a weekday: ");
        input = Console.ReadLine();

        switch(input.ToLower()){
            case "saturday":
            case "sunday":
            case "monday":
            case "wednesday":
                Console.WriteLine("Weekday!");
                break;
            case "thursday":
            case "friday":
                Console.WriteLine("Weekend!");
                break;
            default:
                Console.WriteLine("Invalid input!");
                break;
        }
    }


    //shorthand switching
    static void Shorthand(){
        int digit;

        Console.Write("Enter a digit: ");
        digit = Convert.ToInt32(Console.ReadLine());

        string output = digit switch {
            0 => "Zero",
            1 => "One",
            2 => "Two",
            3 => "Three",
            4 => "Four",
            5 => "Five",
            _ => "Invalid input"
        };

        Console.WriteLine(output);
    }


    //switch type pattern
    static void SwitchType(){
        object input = 10.5;        
        string output = input switch {
            int => "Integer",
            double => "Double",
            string => "String",
            _ => "Not a known type"
        };

        Console.WriteLine(output);
    }


    //switch with condition
    static void SwtichCondition(){
        Console.Write("Enter a digit: ");

        // string msg = number switch{
        //     int num when num < 1 || num > 9 => "Out of range!",
        //     int num when num % 2 == 0 => "even",
        //     int num when num % 2 != 0 => "odd",
        //     _ => "Default case!"
        // };
        // Console.WriteLine($"{number} : {msg}");

        if(int.TryParse(Console.ReadLine(), out int number)){
            string output = number switch{
                int num when num > 0 && num < 10 => num % 2 == 0 ? "Even" : "Odd",
                _ => "Out of Range!"
            };
            Console.WriteLine(output);
        }else {
            Console.WriteLine("Invalid output!");
        }
    }
}