using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndListsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "Red", "Blue", "Green", "Yellow", "Purple" };

            bool isValid = false;
            
            do
            {
                Console.WriteLine("Please enter the index of the string array, 0 - 4.");
                int chosenString = Convert.ToInt32(Console.ReadLine());

                if (0 <= chosenString && chosenString <= 4)
                {
                    Console.WriteLine(stringArray[chosenString]);
                    Console.ReadLine();
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("That index doesn't exist!");
                }
            }
            while (!isValid);

            int[] integerArray = { 5, 10, 20, 40, 80 };

            isValid = false;

            do
            {
                Console.WriteLine("Please enter the index of the integer array, 0 - 4.");
                int chosenInt = Convert.ToInt32(Console.ReadLine());

                if (0 <= chosenInt && chosenInt <= 4)
                {
                    Console.WriteLine(integerArray[chosenInt]);
                    Console.ReadLine();
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("That index doesn't exist!");
                }
            }
            while (!isValid);

            List<string> stringList = new List<string>();
            stringList.Add("Bear");
            stringList.Add("Rabbit");
            stringList.Add("Deer");
            stringList.Add("Raccoon");
            stringList.Add("Squirrel");

            isValid = false;

            do
            {
                Console.WriteLine("Please enter the index of the string list, 0 - 4.");
                int chosenListString = Convert.ToInt32(Console.ReadLine());

                if (0 <= chosenListString && chosenListString <= 4)
                {
                    Console.WriteLine(stringList[chosenListString]);
                    Console.ReadLine();
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("That index doesn't exist!");
                }
            }
            while (!isValid);
        }

        
            
    }
}
