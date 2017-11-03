using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shape 1
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n");

            // Shape 2
            for (int i = 1; i <= 10; i++)
            {

                for (int j = i; j <= 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\n\n");

            // Shape 3
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j <= 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\n\n");


            // Shape 4
            //Console.WriteLine("--------------");
            for (int i = 1; i <= 10; i++)
            {
                //Console.Write("| ");
                for (int j = i; j < 10; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    //System.Threading.Thread.Sleep(5000);
                    Console.Write("*");
                }
            
                //Console.Write(" |");
                Console.WriteLine();
            }
            //Console.WriteLine("--------------");



        }
    }
}
