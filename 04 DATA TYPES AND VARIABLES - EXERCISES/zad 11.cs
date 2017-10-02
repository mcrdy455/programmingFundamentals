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
            float dim = float.Parse(Console.ReadLine()), hours = float.Parse(Console.ReadLine()), minutes = float.Parse(Console.ReadLine()), seconds = float.Parse(Console.ReadLine()), totalSec = hours * 3600 + minutes * 60+seconds;
            Console.WriteLine($"{dim/totalSec}{Environment.NewLine}{dim/1000/totalSec*3600}{Environment.NewLine}{dim/1609/totalSec*3600}");
            //Assume 1 mile = 1609 meters.
        }
    }
}
