using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int lineNumber = 5; lineNumber >= 1; lineNumber--) // there are 5 lines of numbers
            {
                for (int k = 5; lineNumber < k; k = k--)
                {
                    Console.Write(" ");
                }
                for (int i = 1; i <= lineNumber; i++)
                {
                    Console.Write(i); 
                }
                for (int j = lineNumber - 1; j >= 1; j--)
                {
                    Console.Write(j); 
                }
                Console.WriteLine(); // end the line, go to the next line
}
        }
    }
}
