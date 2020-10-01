using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math subtract4 = new Math();
            int subtractResult = Math.Operations(10);
            Console.WriteLine(subtractResult);
            Console.ReadLine();

            Math multiply10 = new Math();
            int multiplyResult = Math.Operations(5.3m);
            Console.WriteLine(multiplyResult);
            Console.ReadLine();

            Math divide3 = new Math();
            int divideResult = Math.Operations("18");
            Console.WriteLine(divideResult);
            Console.ReadLine();
        }
    }
}
