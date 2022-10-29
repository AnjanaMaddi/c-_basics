using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        while(true){
            Console.Write("enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            string options = @"
              enter operation you want to perform:
              1: addition
              2: subtraction
              3: multiplication
              4: division
            ";
            Console.Write(options);
            int selectedOption = Convert.ToInt32(Console.ReadLine());
            switch(selectedOption) {
                case 1: Console.Write("num1 + num2 = "+(num1 + num2)); break;
                case 2: Console.Write("num1 - num2 = "+(num1 - num2)); break;
                case 3: Console.Write("num1 * num2 = "+(num1 * num2)); break;
                case 4: Console.Write("num1 / num2 = "+(num1 / num2)); break;
                default: Console.Write("invalid option"); break;
            }
            Console.WriteLine("press q to exit and any other key to continue");
            string c = Console.ReadLine();
            if(c == "q") {
                break;
            }
        }
    }
}
