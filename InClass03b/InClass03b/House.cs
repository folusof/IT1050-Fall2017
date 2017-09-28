using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass03b
{
    class House
    {
        public double numRooms;
        private string color;
        public int numStories;
        private bool lightsOn;
        private int occupants;

        public void Display()
        {
            Console.WriteLine($"House:\nnumRooms={numRooms}\ncolor={color}\nnumStories={numStories}\nlightsOn={lightsOn}\noccupants={occupants}");
        }

        public void addOccupants(int numPeople)
        {
            occupants += numPeople;
        }

        public void turnLightsOn()
        {
            lightsOn = true;
        }
    }
}
