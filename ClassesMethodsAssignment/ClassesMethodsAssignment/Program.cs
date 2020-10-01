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
            Console.WriteLine("Enter a number to be operated on.");
            int userOperand = Convert.ToInt32(Console.ReadLine());
            int result1 = Math.Multiply5(userOperand);
            Console.WriteLine(userOperand + " * 5 = " + result1);
            int result2 = Math.Add50(result1);
            Console.WriteLine(result1 + " + 50 = " + result2);
            int result3 = Math.Multiply2(result2);
            Console.WriteLine(result2 + " * 2 = " + result3);
            Console.WriteLine("Your result is " + result3);
            Console.ReadLine();
        }
    }
}
