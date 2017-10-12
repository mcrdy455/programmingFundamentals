using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp8
{
   
    class Program
    {
        static int Fib(int a)
        {
            int num = 1;
            int lastNum = 1;
            for (int i = 1; i < a; i++)
            {
                num += lastNum;
                lastNum = num - lastNum;
            }
            return num;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(a));
        }
    }
}
