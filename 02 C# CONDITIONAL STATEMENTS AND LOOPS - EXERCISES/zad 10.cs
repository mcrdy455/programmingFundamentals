using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <= n; i++)
            {
                int a = 1;
                while (a<=i)
                {
                    Console.Write($"{i} ");
                    a++;
                }
                Console.WriteLine();
            }
        }
    }
}
