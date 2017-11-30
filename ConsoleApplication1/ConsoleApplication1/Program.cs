// IT1050 Midterm Project; Fall 2017; Program.cs
// Create various loops within the Main method
using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            
            //*** Solution for Problem 1

            // initialize Boolean variable in declaration
            bool keepLooping = false;

            //while (!keepLooping) // loop-continuation condition; creates infinite loop in this case
            //{
            //    Console.WriteLine("All code and no play, makes me loop all day!"); // display text 
            //}
            //if (keepLooping) // loop-continuation condition if true executes a text display
            //{
            //    Console.WriteLine("Thank you!");
            //}



            //*** Solution for Problem 2

            // initialize control variable declaration
            int var1 = 2;

            while (var1 <= 128) // loop-continuation condition
            {
                Console.WriteLine($"[{var1}]");
                var1 *= 2; //increment loop control variable
            }
            Console.WriteLine(); // Blank line for separation



            //*** Solution for Problem 3

            // initialize control variable declaration
            int var2 = 49;

            while (var2 > 0) // loop-continuation condition
            {
                if (var2 > 1)
                {
                    Console.Write($"{var2},"); //display variable with comma if condition is true
                    --var2; // decrement variable var2
                }
                else
                {
                    Console.Write($"{var2}"); //display variable without comma when if statement is false
                    --var2; // decrement variable var2
                }
            }
            Console.WriteLine(); // Blank line for separation



            //*** Solution for Problem 4

            // initialize control variable in declaration
            int var3 = 1;

            while (var3 <= 21) // loop-continuation condition
            {
                if (var3 % 2 != 0) // determine if var3 is odd
                {
                    Console.Write($"{var3}   "); // diplay var3 if it is odd
                }
                ++var3; // increment var3
            }
            Console.WriteLine(); // Blank line for separation



            //*** Solution for Problem 5

            // initialize variables in declaration
            int n = 8;
            int i = 10;

            do
            {
                Console.Write("*");
                i++;
            } while (i < n);
            // In a while statemen, the app tests the loop-continuation condition at the beginning of the loop, prior to executing
            // the body of the loop. A false condition means the body of the loop never executes. In a do while statement, the app
            // tests the loop-continuation condition after it executes the body of the loop. This means that the body always 
            // executes at least once. 

            Console.WriteLine(); // Blank line for separation



            //*** Solution for Problem 6

            // intialize Boolean variables in declaration
            bool icyRain = false;
            bool tornadoWarning = false;

            if (!(icyRain & tornadoWarning)) // boolean conditional statement; if both values are false
            {
                Console.WriteLine("Let's go outside!"); // display text when above condition is met
            }
            
        }// end Main
    }// end Class Program
}