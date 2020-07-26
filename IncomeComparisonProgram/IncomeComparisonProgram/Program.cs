using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1\nHourly Rate?");
            decimal per1hourlyrate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            decimal per1hoursworked = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Person 2\nHourly Rate?");
            decimal per2hourlyrate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            decimal per2hoursworked = Convert.ToDecimal(Console.ReadLine());

            decimal per1annualsalary = per1hourlyrate * per1hoursworked * 52;
            Console.WriteLine("Annual salary of Person 1:\n" + per1annualsalary);
            decimal per2annualsalary = per2hourlyrate * per2hoursworked * 52;
            Console.WriteLine("Annual salary of Person 2:\n" + per2annualsalary);

            bool incomecompare = per1annualsalary > per2annualsalary;
            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + incomecompare);
            Console.ReadLine();
        }
    }
}
