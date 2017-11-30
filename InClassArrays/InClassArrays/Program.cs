using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = { "Al Dente", "Tim Burr" , "Will Wynn" };
            //names[0] = "Al Dente";
            //names[1] = "Tim Burr";
            //names[2] = "Will Wynn";

            string[,] students = new string[2, 3]
            {
                { "Al Dente", "Tim Burr" , "Will Wynn" },
                { "9", "14", "7" }
            };

            students[0, 0] = "Iona Ford";

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(students[i, j]);
                }
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(students[i, 0] + ": " + students[i, 1]);
            }

            //Console.WriteLine(names);

            //string[] majors = new string[3];
            //majors[0] = "Computer Science";
            //majors[1] = "Programming";
            //majors[2] = "Networking";

            //for (int i = 0; i <= names.Length; i++)
            //{
            //    Console.WriteLine(names[i] + ": " + majors[i]);
            //}

            //List<string> names = new List<string>();
            //names.Add("Anna Graham");
            //names.Add("Iona Ford");
            //names.Add("Ginger Ayle");

            //foreach(string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //for (int i = 0; i < names.Count; i++)
            //{ 
            //    Console.WriteLine(names[i]);
            //}
        }

    }
}
