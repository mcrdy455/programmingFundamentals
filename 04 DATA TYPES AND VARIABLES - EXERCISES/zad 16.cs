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

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double es = 0.000001;
            if (Math.Abs(a-b)<es)
            {
                Console.WriteLine("True");
                            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
