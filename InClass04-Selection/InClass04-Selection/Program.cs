using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass04_Selection
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = 10;

            // Simple if statement
            //  if is the only clause that is required
            if (grade >= 60)
            {
                Console.WriteLine("Passed");
            }

            // WATCH OUT FOR THIS!  IT IS INCORRECT TO INCLUDE A SEMI-COLON AT THE END OF THE STATEMENT
            // DO NOT DO THIS!
            if (grade >= 60) ;
            {
                Console.WriteLine("Great job (even though you did not pass)!");
            }

            // Syntax wise, it's okay to have an if body without curly braces.  
            // I recommend that you always use the curly braces though (esp. when you're just starting out)
            if (grade > 59)
                Console.WriteLine("You passed");

            // if-else statement
            //  Remember: else runs without a condition if the previous clauses do not making it the default clause
            if (grade >= 60)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            // if...else if...else statement
            //  Remember:
            //      - if is the only required clause
            //      - we can have 1 optional else clause
            //      - we can have 0 or more else if clauses
            if (grade >= 90)
            {
                Console.WriteLine("A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }

            // Nested if statement example
            if (grade >= 60)
            {
                Console.WriteLine("Passed");
                if (grade >= 80)
                {
                    Console.WriteLine("Excellent");
                }
                else
                {
                    Console.WriteLine("Well done");
                }
            }

            // We can solve the same problem (nested if) using an if...else if statement 
            if (grade >= 80)
            {
                Console.WriteLine("Passed");
                Console.WriteLine("Excellent");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Passed");
                    Console.WriteLine("Well done");
            }

            // remember that a condition results in a boolean value.
            // it's the boolean value that decides whether or not the if or else if body runs
            if (true)
            {
                Console.WriteLine("Thanks for using the program");
            }

        }
    }
}
