using System;
using System.Collections.Generic;
//sing System.Linq;

namespace _20_Working_with_LINQ
{
    class Program
    {
        static void Main()
        {
            List<Car> myCars = new List<Car>()
            {
                new Car() { VIN = "A1", Make="BMW", Model="550i",StickerPrice=55000, Year=2010},
                new Car() { VIN = "B2", Make="TOYOTA", Model="4runner",StickerPrice=35000, Year=2011},
                new Car() { VIN = "C3", Make="BMW", Model="745li",StickerPrice=75000, Year=2012},
                new Car() { VIN = "D4", Make="FORD", Model="Escape",StickerPrice=25000, Year=2013},
                new Car() { VIN = "E5", Make="BMW", Model="55i",StickerPrice=57000, Year=2014}
            };

//          myCars.Clear();
            myCars.Add(new Car() { VIN = "F6", Make = "AUDI", Model = "A5", StickerPrice = 56000, Year = 2015 });
            myCars.Insert(0, new Car() { VIN = "G7", Make = "Pejo", Model = "106", StickerPrice = 1000, Year = 1997 });
            



            // LINK Query

            // Example 1
            //var bmws = from car in myCars
            //           where car.Make == "BMW"
            //           && car.Year == 2010
            //           select car;
            //PrintOut(bmws);


            //Example 2
            //var orderedCars = from car in myCars
            //                  orderby car.Year descending
            //                  select car;
            //PrintOut(orderedCars);


            // LINK method

            // Example 1 - filter by 2 props
            //var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);
            //PrintOut(bmws);

            // Example 2 - order by year
            //var orderedCars = myCars.OrderByDescending(p => p.Year);
            //PrintOut(orderedCars);

            // Example 3 - order by year desc and pick the first one
            //var firstBMW = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
            //Console.WriteLine(firstBMW.VIN);

            // Example 4 - check condition
            //Console.WriteLine(myCars.TrueForAll(p => p.Year>2009));

            // Example 5 - list the list
            //myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));

            // Example 6 - perform some operation
            //myCars.ForEach(p => p.StickerPrice -= 3000);
            //myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));

            // Example 7 - check if an item exists true/False
            //Console.WriteLine(myCars.Exists(p => p.Model == "745li"));

            // Example 8 - sum up a single field in the collection
            //Console.WriteLine(myCars.Sum(p => p.StickerPrice));

            // Example 9 - check data type / reasoning why using var type 
            //Console.WriteLine(myCars.GetType());
            //var orderedCars = myCars.OrderByDescending(p => p.Year);
            //Console.WriteLine(orderedCars.GetType());
            //var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);
            //Console.WriteLine(bmws.GetType());


            // Example 10 - select items and put them into an anonymous type - Projection!
            //var newCars = from car in myCars
            //              where car.Make == "BMW"
            //              && car.Year == 2010
            //              select new { car.Make, car.Model };
            //Console.WriteLine(newCars.GetType());
            
            Console.ReadLine();

        }
        public static void PrintOut(IEnumerable<Car> car)
        {
            foreach (var item in car)
            {
                Console.WriteLine("{0} {1} {2}", item.Year, item.Model, item.VIN);
            }
            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }

    }
}
