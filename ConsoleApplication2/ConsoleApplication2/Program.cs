using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_DamberPoudel
{
    class Program
    {
        private static int r;

        static void Main(string[] args)
        {
            int i;
            for (i = 30; i <= 44; ++i) ;
            if ((i % 2) == 0)
            {
                Console.Write(i);
                Console.WriteLine(", It's an even number");
            }
            else
            {
                Console.Write(i);
                Console.WriteLine(", It's an odd number");
            }
            {
                //  int i = 10;
                do
                {
                    Console.Write($"{i}\n");
                    ++i;
                }
                while (i < 21);

                {
                    //for (int i = 0; i < 101; a++)
                    Console.WriteLine($"{}\n********");
                }
                const string STAR = "*";
                const int COUNTER = 10;

            }
            {
                Console.ReadLine();

                int COUNTER = 0;
                for (int r = 0; r < COUNTER; r++) ;
                for (int c = 0; c <= r; c++) ;

                Console.Write(STAR);
                Console.WriteLine();


            }
        }
    }
}