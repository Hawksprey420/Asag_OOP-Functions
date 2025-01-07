using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asag_OOP_Functions
{
    internal class LeapYear
    {
            public static bool IsLeapYear(int year)
            {
                // A year is a leap year if it's divisible by 4
                // Except for years divisible by 100, unless they are also divisible by 400
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public static void LeapYear_Main()
            {
                // Example usage of the IsLeapYear function
                int year = 2024;
                if (IsLeapYear(year))
                {
                    Console.WriteLine(year + " is a leap year.");
                }
                else
                {
                    Console.WriteLine(year + " is not a leap year.");
                }
            }
        }
    }