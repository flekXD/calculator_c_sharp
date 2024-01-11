using System;
using Class_Calculator;

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();
        // first number
        Console.WriteLine("first number:");
        calculator.First = Convert.ToInt32(Console.ReadLine());

        // second number
        Console.WriteLine("second number:");
        calculator.Second = Convert.ToInt32(Console.ReadLine());

        // Write operation
        Console.WriteLine("Write operation (+, -, *):");

        //result
        Console.WriteLine(calculator.Calculate(Console.ReadLine()[0]));

        Console.ReadLine();
    }
}