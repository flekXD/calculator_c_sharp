using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Calculator
{
    internal class RPN
    {
        private readonly Dictionary<string, IOperation> operations;

        public RPN()
        {
            operations = new Dictionary<string, IOperation>
            {
                {"+", new AddOperation()},
                {"-", new SubtractOperation()},
                {"*", new MultiplyOperation()},
                {"/", new DivideOperation()}
            };
        }
        internal string[] ConvertToRPN(string expression)
        {
            // Використовуємо алгоритм "зворотній польський запис" (RPN)
            // для обчислення виразу з дужками
            List<string> result = new List<string>();
            Stack<string> operators = new Stack<string>();
            int operation_count = 0;

            string[] tokens = expression.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string token in tokens)
            {
                if (double.TryParse(token, out _))
                {
                    // Якщо токен - число, додаємо його до результату
                    result.Add(token);
                }
                else if (operations.ContainsKey(token))
                {
                    // Якщо токен - операція, видаляємо зі стеку всі операції з вищим пріоритетом і додаємо їх до результату
                    while (operators.Count > 0 && operations.ContainsKey(operators.Peek()) && operations[operators.Peek()].Priority < operations[token].Priority)
                    {
                        result.Add(operators.Pop());
                    }
                    operators.Push(token);
                    operation_count++;
                }
                else if (token == "(")
                {
                    // Якщо токен - відкриваюча дужка, додаємо її до стеку
                    operators.Push(token);
                }
                else if (token == ")")
                {
                    // Якщо токен - закриваюча дужка, видаляємо всі операції зі стеку до відкриваючої дужки і додаємо їх до результату
                    while (operators.Count > 0 && operators.Peek() != "(")
                    {
                        result.Add(operators.Pop());
                    }

                    if (operators.Count == 0)
                    {
                        Console.WriteLine("Некоректні дужки.");
                        return new string[0];
                    }

                    operators.Pop(); // Видаляємо відкриваючу дужку
                }
                else
                {
                    Console.WriteLine($"Некоректний токен: {token}");
                    return new string[0];
                }

                if(result.Count <= operation_count-1)
                {
                    result.Add(null);
                    return result.ToArray();
                }
            }


            // Додаємо залишкові операції зі стеку до результату
            while (operators.Count > 0)
            {
                if (operators.Peek() == "(")
                {
                    Console.WriteLine("Некоректні дужки.");
                    return new string[0];
                }

                result.Add(operators.Pop());
            }

            return result.ToArray();
        }
    }
}
