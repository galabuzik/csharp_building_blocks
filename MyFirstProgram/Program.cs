using System;
using MyUtilities;

namespace MyFirstProgram
{
    class CheckComfort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Where should we go in May?");
            WeatherUtiltites.Report("San Francisco", WeatherUtiltites.FahrenheitToCelsius(65), 73);
            WeatherUtiltites.Report("Denver", WeatherUtiltites.FahrenheitToCelsius(77), 55);
            WeatherUtiltites.Report("Bologna", 23, 65);
        }
  
    }
}
