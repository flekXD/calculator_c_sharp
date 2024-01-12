using System;
using Class_Calculator;

class Program
{
    static void Main()
    {
            Calculator calculator = new Calculator();

            Console.Write("Введіть вираз: ");
            string expression = Console.ReadLine(); //for example 2 + 2 * 2

            double result = calculator.EvaluateExpression(expression);

            if (!double.IsNaN(result))
            {
                Console.WriteLine($"Результат: {result}");
            }
            else
            {
                Console.WriteLine("Неможливо обчислити результат.");
            }

        Console.ReadLine();
    }
}