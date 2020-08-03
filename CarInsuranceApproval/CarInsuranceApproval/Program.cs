using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int driverage = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?");
            bool driverdui = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int drivertickets = Convert.ToUInt16(Console.ReadLine());

            bool driverqualified = driverage > 15 && driverdui == false && drivertickets < 4;
            Console.WriteLine("Qualified?\n" + driverqualified);
            Console.ReadLine();
        }
    }
}
