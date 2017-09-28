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
            string ing;
            int sum = 0;
            asd: ing =Console.ReadLine();
            
            if (ing != "Bake!")
            {
                sum++;
                Console.WriteLine($"Adding ingredient {ing}.");
                goto asd;
            }
            Console.WriteLine($"Preparing cake with {sum} ingredients.");
        }
    }
}

//
