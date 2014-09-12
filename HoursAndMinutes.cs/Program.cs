using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoursAndMinutes.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = 90;
            int display1 = minutes / 60; 
            int display2 = minutes % 60;
            Console.WriteLine("In the total of 90 minutes, there are {0} hours and {1} minutes.", display1, display2);
        }
    }
}
