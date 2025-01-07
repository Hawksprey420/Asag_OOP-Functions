using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asag_OOP_Functions
{
    internal class Heron
    {
        public static double CalculateTriangleArea(double a, double b, double c)
        {
            // Calculate the semi-perimeter (s)
            double s = (a + b + c) / 2;

            // Apply Heron's formula to calculate the area
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        public static void Heron_Main()
        {
            // Example usage of the CalculateTriangleArea function
            double a = 5, b = 6, c = 7;
            double area = CalculateTriangleArea(a, b, c);
            Console.WriteLine("The area of the triangle is: " + area);
        }
    }
}
