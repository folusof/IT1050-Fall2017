using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass09
{
    class MyMath
    {
        public int result;
        public int operand1;
        public int operand2;
        public string lastoperator;

        public int Add(int a, int b)
        {
            operand1 = a;
            operand2 = b;
            lastoperator = "+";
            result = a + b;
            return result;
        }
        public void DisplayLastOperation()
        {
            Console.WriteLine(operand1 + lastoperator + operand2 + "=" + result);
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
