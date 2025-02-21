using System;

class Program{
    public static void Main(string[] args){
        string userName = "Feroj Miah";
        int age = 24;
        double salary = 555.55;
        char bloodGroup = 'O';
        bool isAvailabe = true;

        int num1, num2, num3;
        num1 = num2 = num3 = 5;

        double num4 = (int) num1;
        string strNum = Convert.ToString(num2);

        Console.WriteLine(userName);
        Console.WriteLine(age);
        Console.WriteLine(salary + "$");
        Console.WriteLine(bloodGroup);
        Console.WriteLine(isAvailabe);

        Console.WriteLine(num1 + " " + num2 + " " + num3);
        Console.WriteLine(num4);
        Console.WriteLine(strNum);
    }
}