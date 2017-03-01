/*
 *  Author: Troy Davis
 *  Project: Module06 - CarDealer - Console
 *  Class: IN 2017 (Advanced C#)
 *  Date: Feb 23, 2017 
 *  Revision: Original
 */

using System;

namespace CarDealer
{
    class Program
    {
        static void Main(string[] args)
        {
            // greeting
            Console.WriteLine("Module 06 - Car Dealer");

            // Car example 1
            Car myCar = new Car("Ford", "Mustang", 1967, "Pebble Beige");
            myCar.DisplayProperties("My old car");

            // Car example 2
            Car myNewCar = new Car();
            myNewCar.Make = "Nissan";
            myNewCar.Model = "Titan";
            myNewCar.Year = 2007;
            myNewCar.Color = "Red";
            myNewCar.DisplayProperties("My new car");

            // wait on user to close console
            Console.Write("\nPress 'Enter' to exit: "); Console.ReadLine();
        }
    }
    class Car
    {
        // constructors
        public Car()
        {
            // default constructor
        }
        public Car(string make, string model, int year, string color)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Color = color;
        }

        // setters / getters
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        
        // methods
        public void DisplayProperties(string description)
        {
            Console.WriteLine("\n\t{0} is a {1} {2} {3}. It's color is {4}.", description, this.Year, this.Make, this.Model, this.Color);
        }
    }
}
