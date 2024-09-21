using System;
using System.Security.Cryptography.X509Certificates;

namespace DeCastro
{
    public class HeronsNest
    {
     
        static double HeronsNestFormula(double a,double b, double c)
        {
            double s = (a + b + c) / 2;
            double Area = Math.Abs(s*(s-a)*(s-b)*(s-c));
            
            return Area;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("1st side of the Triangle: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2nd side of the Trianglel: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("3rd side of the Triangle: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double result = HeronsNestFormula(a, b, c);

            Console.WriteLine($"Overall Results{result} ");
        }
    }
}


