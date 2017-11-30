using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass10
{
    class Program
    {
        static void Main(string[] args)
        {
            GermanTranslator GT = new GermanTranslator();
            GT.sayHello("formal");
            Console.WriteLine(GT.isEven(109));
            GT.sayGoodbye();
        }
    }
}
