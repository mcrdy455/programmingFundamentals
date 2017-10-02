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
            double count = double.Parse(Console.ReadLine()),filterTime = double.Parse(Console.ReadLine()),filterFactor = double.Parse(Console.ReadLine()),uloadTime = double.Parse(Console.ReadLine());          
            long sec = (long)(count * filterTime) + (long)(Math.Ceiling(filterFactor  * count / 100) * uloadTime);
            Console.WriteLine($"{sec/86400}:{sec/3600%24:d2}:{sec/60%60:d2}:{sec%60:d2}");
        }
    }
}

