using System;
using System.Timers;

namespace _23_Timer_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer mytimer = new Timer(2000);

            mytimer.Elapsed += Mytimer_Elapsed;
            mytimer.Elapsed += Mytimer_Elapsed1;

            mytimer.Start();

            Console.WriteLine("Press enter to remove the red event.");
            Console.ReadLine();

            mytimer.Elapsed -= Mytimer_Elapsed1;
            Console.ReadLine();

        }

        private static void Mytimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed1: {0:HH:mm:ss.fff}", e.SignalTime);
        }

        private static void Mytimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}",e.SignalTime);
        }
    }
}
