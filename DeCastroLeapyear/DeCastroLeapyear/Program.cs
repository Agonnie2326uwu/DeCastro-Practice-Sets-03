using System;
using System.Runtime.CompilerServices;

namespace DeCastro
{
    public class LeapYear
    {
        static bool LY(int Year)
        {
            if (Year % 4 == 0 && (Year % 100 != 0 || Year % 400 == 0))
            {
                return true;
            }
            return false;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter any Year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            bool results = LeapYear.LY(year);

            if (results==true) 
            {
                Console.WriteLine($"The Year {year} today is a Leap Year");
            }
            else
            {
                Console.WriteLine($"Year {year} today is not a Leap Yeap");
            }










        }
    }
}