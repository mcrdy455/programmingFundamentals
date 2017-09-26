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
            int m = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int last = 0;
            int sum = 0;
            string msg = "asd";

           //Console.Write($"All combinations between {n} and {m} are: ");
            for (int i=n; i <= m; i++)
            {
                for (int k = n; k <= m; k++)
                {
                    //Console.Write($"{i} {k}, ");
                    sum++;
                    if (i + k == x) { msg = $"Number found! {i} + {k} = {x}"; }
                    
                }
            }
            if (msg == "asd") { msg = $"{sum} combinations - neither equals {x}"; }
            Console.Write(msg);
        }
    }
}