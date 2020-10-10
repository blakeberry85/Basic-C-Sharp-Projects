using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterAssignment
{
    class Math
    {
        public int Multiply(int operand1, int operand2 = 2)
        {
            int multiplyResult = operand1 * operand2;
            return multiplyResult;
        }
    }
}
