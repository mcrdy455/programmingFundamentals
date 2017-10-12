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
            double side = double.Parse(Console.ReadLine());
            string ask = Console.ReadLine();
            double output = 0;
            switch (ask)
            {
                case "face":
                    output = Math.Sqrt(2) * side;
                    break;
                case "space":
                    output = side * Math.Sqrt(3);
                    break;
                case "volume":
                    output = side * side * side;
                    break;
                case "area":
                    output = 6 * side * side;
                    break;


            }
            Console.WriteLine(Math.Round(output,2));
        }
    }
}
