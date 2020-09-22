using System;
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;

namespace DefiningAndCallingMethods
{
    class Program                // Input from console and display the reverse name and address
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("The name game!");
            Console.WriteLine("What's you first name?");
            string firstName = Console.ReadLine();
            
            Console.WriteLine("What's you last name?");
            string lastName = Console.ReadLine();
            
            Console.WriteLine("In what city are you born?");
            string city = Console.ReadLine();

            /*                                                      One option  - but repetitive code
            char[] firstNameArray = firstName.ToCharArray();
            Array.Reverse(firstNameArray);

            char[] lastNameArray = lastName.ToCharArray();
            Array.Reverse(lastNameArray);

            char[] cityArray = city.ToCharArray();
            Array.Reverse(cityArray);

            string result = "";

            foreach (char item in firstNameArray)
            {
                result += item;
            }

            result += " ";
            
            foreach (char item in lastNameArray)
            {
                result += item;
            }

            result += " ";

            foreach (char item in cityArray)
            {
                result += item;
            }

            result += " ";

            Console.WriteLine("Result: "+result);
            */
            // option 2: Calling method
            /*
            Console.WriteLine("Results: ");
            ReverseString(firstName);
            ReverseString(lastName);
            ReverseString(city);
            */

            DisplayResults(ReverseString(firstName), ReverseString(lastName), ReverseString(city));

            Console.ReadLine();
        }
        // Option 3: The game name with reverse and calling methods

        /*
        private static void ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            foreach (char item in messageArray)
            {
                Console.Write(item);
            }
            Console.Write(" ");

        }
        */

                                                        // Option 4
        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            //return String.Concat(messageArray);
            return new string (messageArray);
        }

        private static void DisplayResults(
            string reversedFirstName, 
            string reversedLastName, 
            string reversedCity)
        {
            Console.Write(String.Format("Result is: {0} {1} {2}",
                reversedFirstName,
                reversedLastName,
                reversedCity));
        }

    }
}
