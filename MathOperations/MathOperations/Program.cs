using System;

namespace MathOperations
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your first number:");
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            int firstresult = firstnumber * 50;
            Console.WriteLine(firstnumber + " multiplied by 50 equals: " + firstresult);
            Console.WriteLine("Enter your second number:");
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            int secondresult = secondnumber + 25;
            Console.WriteLine(secondnumber + " plus 25 equals: " + secondresult);
            Console.WriteLine("Enter your third number:");
            double thirdnumber = Convert.ToDouble(Console.ReadLine());
            double thirdresult = thirdnumber / 12.5;
            Console.WriteLine(thirdnumber + " divided by 12.5 equals: " + thirdresult);
            Console.WriteLine("Enter your fourth number:");
            int fourthnumber = Convert.ToInt32(Console.ReadLine());
            bool fourthresult = fourthnumber > 50;
            Console.WriteLine(fourthnumber + " > 50: " + fourthresult);
            Console.WriteLine("Enter your fifth number:");
            int fifthnumber = Convert.ToInt32(Console.ReadLine());
            int fifthresult = fifthnumber % 7;
            Console.WriteLine(fifthnumber + " divided by 7 leaves a remainder of: " + fifthresult);
            Console.ReadLine();
        }
    }
}
