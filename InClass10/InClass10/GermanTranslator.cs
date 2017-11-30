using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass10
{
    class GermanTranslator
    {
        public void sayHello()
        {
            Console.WriteLine("Guten Tag!");
        }
        
        public void sayGoodbye()
        {
            Console.WriteLine("Auf Wiedersehen");
        }

        public void sayHello(string greetingType)
        {
            if (greetingType.ToLower() == "formal")
            {
                Console.WriteLine("Wie geht es Ihnen?");
            }
            else
            {
                Console.WriteLine("Wie geht es dir?");
            }
        }

        public bool isEven(int number)
        {
            if (number % 2 == 0)
            { 
                return true;
            }

            return false;
        }
    }
}
