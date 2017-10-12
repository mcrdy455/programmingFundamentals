using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp8
{

    class Program
    {       
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "triangle":
                    double a = double.Parse(Console.ReadLine());
                    double h = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{(a * h/2):f2}");
                    break;
                case "square":
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{b * b:f2}");
                    break;
                case "rectangle":
                    double c = double.Parse(Console.ReadLine());
                    double d = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{(c * d):f2}");
                    break;
                case "circle":
                    double r = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{r*r*Math.PI:f2}");
                    break;
            }
        }
    }
}
