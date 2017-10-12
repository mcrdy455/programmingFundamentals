using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace ConsoleApp8
{

    class Program
    {
        
        public static int Trail(int n)
        {
            int trail = 0;
            
            for (int i = n; i >= 1; i=i/5)
            {
                trail += i / 5;


            }
            return trail;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Trail(n));
        }
    }
}
