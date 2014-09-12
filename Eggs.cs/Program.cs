using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eggs.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int chicken1 = 50, chicken2 = 45, chicken3 = 47, chicken4 = 40;
            int sum = chicken1 + chicken2 + chicken3 + chicken4;
            int display1 = sum / 12;
            int display2 = sum % 12;
            Console.WriteLine("The total of the four eggs, there are {0} dozen eggs and {1} remaining eggs.", display1, display2);
        }
    }
}
