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
        public static BigInteger Fact(int n)
        {
            BigInteger f=1;
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            return f;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fact(n));
        }
    }
}