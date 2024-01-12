using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Calculator
{
    public class DivideOperation : IOperation
    {
        public int Priority => 0;
        public double Execute(double first, double second)
        {
            if (second == 0)
            {
                Console.WriteLine("Ділення на нуль неможливе.");
                return double.NaN;
            }

            return first / second;
        }
    }
}
