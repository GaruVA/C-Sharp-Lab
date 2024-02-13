// Build an application to store and display the temperatures of a week using an array.
// Create a class named Temperature Tracker' with an array to store daily temperatures.
// Implement a method to display the temperatures.
// Instantiate an object, input temperatures, and display the weekly temperature report.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Q03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureTracker temperatureTracker = new TemperatureTracker();
            string[] days = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            Console.WriteLine("Enter daily temperatures of this week:");
            for (int i = 0; i < days.Length; i++)
            {
                Console.Write($"{days[i]}: ");
                temperatureTracker.dailyTemperatures[i] = Convert.ToDecimal(Console.ReadLine());
            }
            temperatureTracker.DisplayDailyTemperatures();
        }
    }
    class TemperatureTracker
    {
        public decimal[] dailyTemperatures = new decimal[7];

        public void DisplayDailyTemperatures()
        {
            Console.Write("Daily Temperatures: [ ");
            for (int i = 0; i < dailyTemperatures.Length - 1; i++)
            {
                Console.Write($"{dailyTemperatures[i]}, ");
            }
            Console.WriteLine($"{dailyTemperatures[dailyTemperatures.Length - 1]} ]");
            Console.WriteLine($"Average Temperature for this week: {dailyTemperatures.Sum() / 7}");
        }
    }
}
