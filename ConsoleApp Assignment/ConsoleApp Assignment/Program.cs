using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] stringArray = { " table", " chair", " couch", " bed" };

            //Console.WriteLine("Type an adjective");
            //string userString = Console.ReadLine();

            //for (int i = 0; i < stringArray.Length; i++)
            //{
            //    stringArray[i] = userString + stringArray[i];
            //    Console.WriteLine(stringArray[i]);
            //}
            //Console.ReadLine();


            //for (int i = 0; i < 10;)
            //{
            //    Console.WriteLine("Infinity");
            //}


            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();


            //for (int i = 5; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();


            //List<string> animals = new List<string>() { "tiger", "lion", "cheetah", "leopard" };
            //Console.WriteLine("Search for a big cat.");
            //string userInput = Console.ReadLine().ToLower();
            //int animalIndex = -1;
            //for (int i = 0; i < animals.Count; i++)
            //{
            //    if (animals[i] == userInput)
            //    {
            //        animalIndex = i;
            //        break;
            //    }
            //}
            //if (animalIndex == -1)
            //{
            //    Console.WriteLine("That cat doesn't exist!");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("That cat is at index " + animalIndex + " in the array.");
            //    Console.ReadLine();
            //}



            //List<string> animals = new List<string>() { "tiger", "lion", "cheetah", "leopard", "lion" };
            //Console.WriteLine("Search for a big cat.");
            //string userInput = Console.ReadLine().ToLower();
            //List<int> animalIndices = new List<int>();
            //for (int i = 0; i < animals.Count; i++)
            //{
            //    if (animals[i] == userInput)
            //    {
            //        animalIndices.Add(i);
            //    }
            //}
            //if (animalIndices.Count == 0)
            //{
            //    Console.WriteLine("That cat doesn't exist!");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("Index:");
            //    foreach (int animalIndex in animalIndices)
            //    {
            //        Console.WriteLine(animalIndex);
            //    }
            //    Console.ReadLine();
            //}


            List<string> colors = new List<string>() { "red", "blue", "blue", "black", "white", "black", "red" };
            List<string> colors2 = new List<string>();
            foreach (string color in colors)
            {
                if (colors2.Contains(color))
                {
                    string colorEval = color + " - This color has already appeared in the list.";
                    Console.WriteLine(colorEval);
                }
                else
                {
                    colors2.Add(color);
                    Console.WriteLine(color);
                }
            }
            Console.ReadLine();
        } 
    }
}
