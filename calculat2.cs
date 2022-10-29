using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter the operation ex \"1 + 2\"");
        string[] operation = Console.ReadLine().Split(" ");
        double num1 = Convert.ToDouble(operation[0]);
        double num2 = Convert.ToDouble(operation[2]);
        switch(operation[1]) {
            case "+": Console.Write(num1 + num2); break;
            case "-": Console.Write(num1 - num2); break;
            case "*": Console.Write(num1 * num2); break;
            case "/": Console.Write(num1 / num2); break;
            default: Console.Write("invalid option"); break;
        }
    }
}
