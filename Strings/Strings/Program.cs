using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "The quick brown ";
            string string2 = "fox jumped over ";
            string string3 = "the lazy dog.";
            string string123 = string1 + string2 + string3;

            string123 = string123.ToUpper();

            StringBuilder stringparagraph = new StringBuilder();
            stringparagraph.Append(string123);
            stringparagraph.Append("\nThis sentence is a pangram.");
            stringparagraph.Append("\nThis means that it contains every letter of the alphabet.");
            stringparagraph.Append("\nIt is the most widely known pangram due to being easy to read.");
            Console.WriteLine(stringparagraph);
            Console.ReadLine();
        }
    }
}