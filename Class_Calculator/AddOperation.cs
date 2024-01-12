using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Calculator
{
    public class AddOperation : IOperation
    {
        public int Priority => 1;
        public double Execute(double first, double second)
        {
            return first + second;
        }
    }
}
