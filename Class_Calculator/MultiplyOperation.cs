using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Calculator
{
    internal class MultiplyOperation : IOperation
    {
        public int Priority => 0;
        public double Execute(double first, double second)
        {
            return first * second;
        }
    }
}
