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
            int max = int.Parse(Console.ReadLine());
            int sum = 0;
            int comb = 0;
            for (int i = n; i > 0; i--)
            {
                for (int k = 1; k <= m; k++)
                {
                    //Console.Write($"{i} {k};");                    
                    sum = sum + 3 * (i * k);
                    comb++;
                    if (sum>= max) { break; }
                    
                }
                if (sum >= max) { break; }
            }
            Console.WriteLine();
            if (sum >= max)
            {
                Console.WriteLine($"{comb} combinations");
                Console.WriteLine($"Sum: {sum} >= {max}");
            }
            else
            {
                Console.WriteLine($"{comb} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
