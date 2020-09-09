using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int>() { 10, 50, 100, 200, 400, 800 };
                Console.WriteLine("Enter a divisor");
                int divisor = Convert.ToInt32(Console.ReadLine());
                foreach (int number in numbers)
                {
                    int dividedNumber = number / divisor;
                    Console.WriteLine(dividedNumber);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            Console.WriteLine("Continuing on...");
            Console.ReadLine();
        }
    }
}
