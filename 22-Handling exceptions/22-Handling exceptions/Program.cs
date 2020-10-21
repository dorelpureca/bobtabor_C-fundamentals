using System;
using System.IO;

namespace _22_Handling_exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Tools\Exampl.txt");
                Console.WriteLine(content);
                Console.ReadLine();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure that the name of the file is named corretly Example.txt");
                Console.WriteLine(ex.Message);
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(@"Make sure that the directory exists C:\Tools");
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Code to finalize
                // Setting objects to null
                // Closing databas connections
                Console.WriteLine("Closing application now ...");
            }
            Console.ReadLine();
        }
    }
}
