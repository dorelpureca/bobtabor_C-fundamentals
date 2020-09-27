using ScrapeLibrary;
using System;

namespace ScrapeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Scrape myScrape = new Scrape();
            string filepath = "My text.txt";
            string url = "http://isitfridayyet.net";

            //string reply= myScrape.ScrapeWebpage(url);
            string reply = myScrape.ScrapeWebpage(url, filepath);

            Console.WriteLine(reply);
            Console.ReadLine();
        }
    }
}
