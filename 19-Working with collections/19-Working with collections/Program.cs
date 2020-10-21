using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace _19_Working_with_collections
{
    class Program
    {
        static void Main()
        {
            /*
            Car car1 = new Car();
            car1.VIN = "A1";
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";

            Car car2 = new Car();
            car2.VIN = "B2";
            car2.Model = "Geo";
            car2.Make = "Prism";

            Book b1 = new Book();
            b1.Author = "Robert Tabor";
            b1.Title = "Microsoft .net";
            b1.ISBN = "0-0000-000000-00";
            */


            // ArrayLists are dynamically sized
            // cool features sorting, remove items

            /*
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);
            myArrayList.Remove(b1);
            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            */


            /*
            // List<T> Generic list
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(b1);
            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }
            */

            
             
            /* 
            // Dictionary<TKey,TValue>

            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);
            Console.WriteLine(myDictionary["B2"].Make);
            */


            //string[] names = {"Bob", "Steve", "Brian", "Chuck"};
            // Object initializer
            // no need for a Constructor
            Car car1 = new Car() { Make = "BMW", Model = "750", VIN = "C3" };
            Car car2 = new Car() { Make = "Toyota", Model = "4rrunner", VIN = "D4" };


            //Collection initializer
            List<Car> myList = new List<Car>()
            {
                new Car {Make = "Oldsmobile", Model="Cutlas SUpreme", VIN="E5"},
                new Car {Make = "Nissan", Model="Altima", VIN="F6"}
            };

            Console.ReadLine();

        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
