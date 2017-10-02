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
            string firstName  = Console.ReadLine(), secondName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long personalID = long.Parse(Console.ReadLine()), emploID = long.Parse(Console.ReadLine());
            Console.WriteLine($"First name: {firstName}{Environment.NewLine}Last name: {secondName}{Environment.NewLine}Age: {age}{Environment.NewLine}Gender: {gender}{Environment.NewLine}Personal ID: {personalID}{Environment.NewLine}Unique Employee number: {emploID}");
        }
    }
}
