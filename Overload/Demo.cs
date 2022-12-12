using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    internal class Demo
    {
        public int CalculateSum (int number1, int number2)
        {
            return number1 + number2;
        }

        // Types of params
        public int CalculateSum(int number1, string number2)
        {
            var intNumber2 = int.Parse(number2);
            return number1 + intNumber2;
        }
        // Number of parameters
        public int CalculateSum(int number1, int number2, int number3)
        {
            return CalculateSum(number1, number2) + number3;
        }
    }
}
