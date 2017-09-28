using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass03b
{
    class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House();
            house1.numRooms = 8d;
            house1.numStories = 2;
            house1.Display();

            Console.WriteLine("\n");

            House house2 = new House();
            house2.Display();
            Console.WriteLine("\n");

            house2.numRooms = 6d;
            house2.numStories = 1;
            for (int i = 0; i < 5; i++)
            {
                house2.addOccupants(1);
            }
            house2.turnLightsOn();

            house2.Display();
            Console.WriteLine("\n");
        }
    }
}
