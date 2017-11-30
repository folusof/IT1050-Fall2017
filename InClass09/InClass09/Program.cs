using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass09
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Al Dente";
            string greeting = "Hello from";
            Console.WriteLine($"\(name) \(greeting");

            /*
            Calling static methods from within Program.cs
            int sum = AddNumbers(5, 6, 7);
            Console.WriteLine(sum);
            */

            // static method call to Multiply
            int product = MyMath.Multiply(7, 3);
            Console.WriteLine("Product: " + product);
       
            // non-static method calls
            MyMath mathObj1 = new MyMath();
            int sum = mathObj1.Add(7, 3);
            mathObj1.DisplayLastOperation();
            
        }

        /*
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }
        static int AddNumbers(int a, int b, int c)
        {
            return a + b + c;
        }
        */
    }
}
