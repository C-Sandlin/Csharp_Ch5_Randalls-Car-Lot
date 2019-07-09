using System;
using System.Collections.Generic;

namespace randalls_car_lot
{
    class Program
    {
        static void Main(string[] args)
        {
            var ford = new Dictionary<string, string>()
            {
                {"Year", "1914"},
                {"Make", "Ford"},
                {"Model", "T"},
                {"Price", "300"}

            };

            var tesla = new Dictionary<string, string>()
            {
                {"Year", "2017"},
                {"Make", "Tesla"},
                {"Model", "X"},
                {"Price", "80000"}

            };

            var garage = new List<Dictionary<string, string>>();

            garage.Add(ford);
            garage.Add(tesla);

            ////
            // BETTER WAY BELOW, USING CLASSES
            ////

            var ford2 = new Car();
            ford2.Year = 2017;
            ford2.Make = "Ford";
            ford2.Model = "Fiesta";
            ford2.Price = 250.00;

            // or this format
            var tesla2 = new Car()
            {
                Year = 2017,
                Model = "Model X",
                Make = "Tesla",
                Price = 800000.42,
            };

            var toyota = new Car()
            {
                Year = 2018,
                Make = "Toyota",
                Price = 30000.92
            };

            var garage2 = new List<Car>()
            {
                ford2, tesla2
            };

            tesla2.Drive(100);
            ford2.Drive(100.0);
            toyota.Drive();

        }
    }

    class Car
    {
        public int Year { get; set; }

        public string Model { get; set; }

        public string Make { get; set; }

        public double Price { get; set; }

        // writing a method(void bc not returning anything)
        public void Drive()
        {
            if (Model == null)
            {
                Console.WriteLine($"Sorry Dawg, no model");
            }
            else
            {
                Console.WriteLine($"I'm driving the {Make} {Model}");
            }
        }

        public void Drive(int miles)
        {
            Console.WriteLine($"{Make} is driving for {miles} miles");
        }

        public void Drive(double gallons)
        {
            Console.WriteLine($"{Make} uses {gallons} number of gallons");
        }
    }
}
