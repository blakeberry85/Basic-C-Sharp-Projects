using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string studentCourse = Console.ReadLine();

            Console.WriteLine("What page number?");
            string studentpg = Console.ReadLine();
            ushort studentpage = Convert.ToUInt16(studentpg);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string studenthp = Console.ReadLine();
            bool studenthelp = Convert.ToBoolean(studenthp);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveexp = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            float hoursstudied = Convert.ToSingle(hours);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
