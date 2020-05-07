using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MVC_Countries_Lab
{
    class CountryView
    {
        public Country DisplayCountry { set; get; }
        public void Display()
        {
            Console.Write(DisplayCountry.Name + " on the Continent of " +
            DisplayCountry.Continent + " has the colors: ");

            DisplayColor(DisplayCountry.Colors[0]);

            for (int i=1; i < DisplayCountry.Colors.Count; i++)
            {
                Console.Write(",");
                DisplayColor(DisplayCountry.Colors[i]);
            }

            Console.WriteLine();
        }

        public void DisplayColor( string color)
        {
            var consoleColor = color switch
            {
                "Red" => ConsoleColor.Red,
                "White" => ConsoleColor.White,
                "Light blue" => ConsoleColor.Blue,
                "Blue" => ConsoleColor.Blue,
                "Yellow" => ConsoleColor.Yellow,
                "Gold" => ConsoleColor.DarkYellow,
                "Green" => ConsoleColor.Green,
                _ => throw new ArgumentException("color not found", color)
            };

            Console.ForegroundColor = consoleColor;
            Console.Write( color );
            Console.ResetColor();
        }
    }
}
