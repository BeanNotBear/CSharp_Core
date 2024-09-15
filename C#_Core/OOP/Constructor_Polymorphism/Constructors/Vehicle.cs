using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C__Core.OOP.Constructor_Polymorphism.Constructors
{
    public class Vehicle
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        // Create a class constructor with non parameters
        public Vehicle()
        {
            Model = "Ford Mustang";
            Color = "Red";
            Year = 2022;
        }

        // Create a class constructor with multiple parameters
        public Vehicle(string model, string color)
        {
            Model = model;
            Color = color;
            Year = 2003;
        }

        // Create a class constructor with full parameters
        public Vehicle(string model, string color, int year)
        {
            Model = model;
            Color = color;
            Year = year;
        }

        public override string ToString()
        {
            return $"Model: {Model}, Color: {Color}, Year: {Year}";
        }
    }
}
