using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                for (int i = b; i <= a; i++)
                {
                    Console.WriteLine($"{i}");
                }
            }
            else
            {
                for (int k = a; k <= b; k++)
                {
                    Console.WriteLine($"{k}");
                }
            }
        }
    }
}
//
