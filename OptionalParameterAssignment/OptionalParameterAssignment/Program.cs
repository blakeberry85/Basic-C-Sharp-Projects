using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math multiply1 = new Math();
            Console.WriteLine("Please enter two numbers one at a time. First number is required, second number will default to 2 if left blank.");
            int operand1 = Convert.ToInt32(Console.ReadLine());
            string operand2 = Console.ReadLine();
            int multiplyResult = 0;
            if (operand2 == String.Empty)
            {
                multiplyResult = multiply1.Multiply(operand1);
            }
            else
            {
                int convertOperand2 = Convert.ToInt32(operand2);
                multiplyResult = multiply1.Multiply(operand1, convertOperand2);
            }
            Console.WriteLine("Your answer is " + multiplyResult);
            Console.ReadLine();
        }
    }
}
