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
            math = Math.Multiply5(math);
            Console.WriteLine(math.userOperand + " * 5 = " + math.result);
            math = Math.Add50(math);
            Console.WriteLine("+ 50 = " + math.result);
            math = Math.Multiply2(math);
            Console.WriteLine("* 2 = " + math.result);
            Console.WriteLine("Your result is " + math.result);
            Console.ReadLine();

        }
    }
}
