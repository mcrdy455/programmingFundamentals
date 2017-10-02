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
            int a= int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Before:{Environment.NewLine}a = {a}{Environment.NewLine}b = {b} {Environment.NewLine}After: {Environment.NewLine}a = {b} {Environment.NewLine}b = {a}");
        }
    }
}
