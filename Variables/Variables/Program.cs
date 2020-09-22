using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;
            Console.WriteLine(y);
            Console.ReadLine();
            */

            Console.WriteLine("what is your name?");
            Console.WriteLine("Type your first name:");
            string myFirstName;
            myFirstName = Console.ReadLine();

            Console.WriteLine("Type your second name:");
            // string myLastName;
            // myLastName = Console.ReadLine();

            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName+"!");
                                
            Console.ReadLine();
        }
    }
}
