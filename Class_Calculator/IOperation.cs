using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Calculator
{
    public interface IOperation
    {
        int Priority { get; }
        double Execute(double first, double second);
    }
}
