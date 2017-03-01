/*
 *  Author: Troy Davis
 *  Project: Module06 - Lesson02 - Console
 *  Class: IN 2017 (Advanced C#)
 *  Date: Mar 01, 2017 
 *  Revision: Original
 */

using System;

namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            // greeting
            Console.WriteLine("Module 06 - Lesson 02\n");

            // example instantiation 1
            Rectangle rect1 = new Rectangle(10.0, 20.0);// using overloaded constructor
            double area1 = rect1.GetArea();
            Console.WriteLine("\tArea of Rectangle 1: {0}", area1);

            // example instantiation 2
            Rectangle rect2 = new Rectangle();// using default constructor
            rect2.Length = 15.0;
            rect2.Width = 22.0;
            double area2 = rect2.GetArea();
            Console.WriteLine("\tArea of Rectangle 2: {0}", area2);

            // wait on user to close console
            Console.Write("\nPress 'Enter' to exit: "); Console.ReadLine();
        }
    }
    class Rectangle
    {
        // contructors
        public Rectangle()
        {
            // default constructor - doing nothing here
        }
        public Rectangle(double length, double width)
        {
            // example of using this keyword; allows input field names to shadow class property names
            this.length = length;
            this.width = width;
        }

        // properties (manually implemented)
        private double length;
        private double width;
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value > 0.0)
                    length = value;
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0.0)
                    width = value;
            }
        }
        // properties (auto-implemented)
        /*
        public double Length { get; set; }
        public double Width { get; set; }
        */

        // methods
        public void InitFields(double l, double w)
        {
            length = l;
            width = w;
        }
        public double GetArea()
        {
            return length * width;
        }
    }
}
