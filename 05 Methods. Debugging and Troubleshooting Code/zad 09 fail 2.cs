using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp8
{

    class Program
    {
        static double Lenth(double a, double b, double c, double d)
        {
            double dist = Math.Sqrt((a * a - c * c) + (b * b - d * d));
            return dist;
        }

        static double Dist(double a, double b)
        {
            double dist = Math.Sqrt(a * a + b * b);
            return dist;
        }
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            if (Lenth(x1, y1, x2, y2) >= Lenth(x3, y3, x4, y4))
            {
                if (Dist(x1, y1) <= Dist(x2, y2))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (Dist(x3, y3) <= Dist(x4, y4))
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }
    }
}
