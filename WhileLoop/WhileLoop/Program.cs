using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string color = "white";
            bool isCorrectColor = color == "blue";

            while (!isCorrectColor)
            {
                Console.WriteLine("What color is the sky? Don't use capitalization.");
                color = Console.ReadLine();
                

                switch (color)
                {
                    case "blue":
                        Console.WriteLine("Correct! The sky is blue.");
                        isCorrectColor = true;
                        break;
                    case "green":
                        Console.WriteLine("Sorry, green is not correct.");
                        break;
                    case "red":
                        Console.WriteLine("Sorry, red is not correct.");
                        break;
                    default:
                        Console.WriteLine("Sorry, that is not correct.");
                        break;
                }
            }            


            Console.WriteLine("What is 50 * 5?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isCorrectNumber = number == 250;
            do
            {
                switch (number)
                {
                    case 55:
                        Console.WriteLine("Sorry, 55 is not correct.");
                        Console.WriteLine("What is 50 * 5?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 255:
                        Console.WriteLine("Sorry, 255 is not correct.");
                        Console.WriteLine("What is 50 * 5?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("Sorry, 10 is not correct.");
                        Console.WriteLine("What is 50 * 5?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 250:
                        Console.WriteLine("Correct! 50 * 5 is 250.");
                        isCorrectNumber = true;
                        break;
                    default:
                        Console.WriteLine("Sorry, that is not correct.");
                        Console.WriteLine("What is 50 * 5?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isCorrectNumber);

            Console.Read();
        }
    }
}
