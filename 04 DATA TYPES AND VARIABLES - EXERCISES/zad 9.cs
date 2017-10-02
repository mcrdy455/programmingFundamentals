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
            char first = char.Parse(Console.ReadLine()), second = char.Parse(Console.ReadLine()), third = char.Parse(Console.ReadLine());
            Console.WriteLine($"{third}{second}{first}");
        }
    }
}
