using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMethodsAssignment
{
    public class Math
    {
        public int userOperand { get; set; }
        public int result { get; set; }

        public static Math Multiply5(Math math)
        {
            math.result = math.userOperand * 5;
            return math;
        }

        public static Math Add50(Math math)
        {
            math.result = math.result + 50;
            return math;
        }

        public static Math Multiply2(Math math)
        {
            math.result = math.result * 2;
            return math;
        }
    }



}
