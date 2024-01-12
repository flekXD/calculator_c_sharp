namespace Class_Calculator
{
    public class Calculator
    {
        private readonly Dictionary<string, IOperation> operations;

        public Calculator()
        {
            operations = new Dictionary<string, IOperation>
            {
                {"+", new AddOperation()},
                {"-", new SubtractOperation()},
                {"*", new MultiplyOperation()},
                {"/", new DivideOperation()}
            };
        }

        public double EvaluateExpression(string expression)
        {
            RPN rpn = new RPN();
            string[] tokens = rpn.ConvertToRPN(expression);
            Stack<double> stack = new Stack<double>();

            if(tokens.Length > 2) { 
                foreach (string token in tokens)
                {
                    if (double.TryParse(token, out double operand))
                    {
                        stack.Push(operand);
                    }
                    else if (operations.ContainsKey(token))
                    {
                        double secondOperand = stack.Pop();
                        double firstOperand = stack.Pop();
                        double result = operations[token].Execute(firstOperand, secondOperand);
                        stack.Push(result);
                    }
                    else
                    {
                        Console.WriteLine($"Некоректний токен: {token}");
                        return double.NaN;
                    }
                }
            }
            if (stack.Count != 1)
            {
                Console.WriteLine("Некоректний вираз.");
                return double.NaN;
            }

            return stack.Pop();
        }

    }
}
