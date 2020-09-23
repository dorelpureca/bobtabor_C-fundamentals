using System;
namespace Decissions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*                                  First example
          
             Console.WriteLine("Bob's Big Giveaway!");
             Console.WriteLine("Choose a door: 1, 2 or 3:");
             string userValue = Console.ReadLine();

             string message = "";

             if (userValue == "1")
                 message = "You won a new car!";
             else if (userValue == "2")
                 message = "You won a new boat!";
             else if (userValue == "3")
                 message = "You won a new cat!";
             else
             {
                 message = "Try again, we didn't understand!";
                 //message = message + "You lose!";
                 message += "You lose.";
             }

             Console.WriteLine(message);
             Console.ReadLine();
             */

            Console.WriteLine("Bob's Big Giveaway!");
            Console.WriteLine("Choose a door: 1, 2 or 3:");
            string userValue = Console.ReadLine();

                                            // Second example

            string message = (userValue == "1") ? "boat" : "strand of lint";
            //Console.Write("You won a ");
            //Console.Write(message);
            //Console.Write(".");
                                            // 3rd example
            //Console.WriteLine("You won a {0}.", message);

                                            // 4th example
            Console.WriteLine("You entered: {0}, therefore you won a {1}.", userValue, message);
                        
            Console.ReadLine();

        }
    }
}
