using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carpet.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 10;
            int width = 20;
            int area = length * width;
            double cost = 5.30;
            double total = cost * area;
            Console.WriteLine("The cost of carpteing per square foot is $" + total);

        }
    }
}
