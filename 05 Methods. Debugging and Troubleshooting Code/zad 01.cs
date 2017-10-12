using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp8
{
   
    class Program
    {
        static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
        static void Main(string[] args)
        {
            Greet(Console.ReadLine());
        }
    }
}
