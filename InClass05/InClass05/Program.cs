using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass05
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 11;

            //while (i > 0)
            //{
            //    // i = i - 1;

            //    // Compound addition operator
            //    // Compound opertors: +=, -=, *=, /=, %=
            //    //i -= 3;

            //    // increment/decrement operators
            //    //i--;
            //    --i;

            //    Console.WriteLine(i + " ");
            //}
            //Console.WriteLine("Houston, we have ignition.");

            /*
            int i = 1;
            int counter = 0;
            while (i < 800)
            {
                i *= 3;
                Console.WriteLine(i);
                counter++;
            }
            Console.WriteLine("The loop ran " + counter + " times.");
            */

            // indefinite repetition with a sentinel value
            string input = "";
            while (input != "e")
            {
                Console.Write("Enter a value (e to end): ");
                input = Console.ReadLine();
            }
        }
    }
}
