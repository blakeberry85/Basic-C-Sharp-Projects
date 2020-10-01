using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingAssignment
{
    class Math
    {
        public static int Operations(int operand)
        {
            operand = operand - 4;
            return operand;
        }

        public static int Operations(decimal operand)
        {
            operand = operand * 10;
            return Convert.ToInt32(operand);
        }

        public static int Operations(string operand)
        {
            int convertOperand = 0;
            try
            {
                convertOperand = Convert.ToInt32(operand);
            }
            catch (FormatException)
            {
                Console.WriteLine("That string cannot be converted to an integer!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.ReadLine();
                Environment.Exit(0);
            }
            convertOperand = convertOperand / 3;
            return convertOperand;
        }
    }
}
