namespace Class_Calculator
{
    public class Calculator
    {
        private double first;
        private double second;


        //get and set operations
        public double First
        {
            get { return first; }
            set { first = value; }
        }

        public double Second
        {
            get { return second; }
            set { second = value; }
        }

        //default constructor
        public Calculator(double first, double second)
        {
            this.first = first;
            this.second = second;
        }
        private double Add()
        {
            return First + Second;
        }

        private double Subtract()
        {
            return First - Second;
        }

        private double Multiply()
        {
            return First * Second;
        }

        public double Calculate(char operation)
        {
            double result;
            if (operation == '+')
            {
                result = Add();
            }
            else if (operation == '-')
            {
                result = Subtract();
            }
            else if (operation == '*')
            {
                result = Multiply();
            }
            else
            {
                Console.WriteLine("Error. Please write correct operation");
                result = double.NaN;
            }
            return result;
        }
    }
}
