using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yards.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 25, width = 42, area = length * width;
            double squareyard = (length * width) / 9;
            double cost = 4.50;
            double total = cost * squareyard;
            Console.WriteLine("the cost per square yard is " + cost + ". In all, it would be " + total);

        }
    }
}
