using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Enter a number to be operated on.");
            math.userOperand = Convert.ToInt32(Console.ReadLine());
            math = Multiply5(math);
            Console.WriteLine(math.userOperand + " * 5 = " + math.result);
            math = Add50(math);
            Console.WriteLine("+ 50 = " + math.result);
            math = Multiply2(math);
            Console.WriteLine("* 2 = " + math.result);
            Console.WriteLine("Your result is " + math.result);
            Console.ReadLine();

        }

        public static Math Multiply5(Math math)
        {
            math.result = math.userOperand * 5;
            return math;
        }

        public static Math Add50(Math math)
        {
            math.result = math.result + 50;
            return math;
        }

        public static Math Multiply2(Math math)
        {
            math.result = math.result * 2;
            return math;
        }
    }
}
