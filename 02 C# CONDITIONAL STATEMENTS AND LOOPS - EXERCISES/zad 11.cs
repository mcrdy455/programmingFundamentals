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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (Math.Abs(a-b)<5) { Console.WriteLine("No"); }
            else
            {
                if (b<a)
                {
                    int c = a;
                    a = b;
                    b = c;
                }
                for (int i = a; i <= b-4; i++)
                {
                    for (int i2 = a+1; i2 <= b-3; i2++)
                    {
                        for (int i3 = a+2; i3 <= b-2; i3++)
                        {
                            for (int i4 = a+3; i4 <= b-1; i4++)
                            {
                                for (int i5 = a+4; i5 <= b; i5++)
                                {
                                    if (i != i2 && i != i3 && i != i4 && i != i5 && i2 != i3 && i2 != i4 && i2 != i5 && i3 != i4 && i3 != i5 && i4 != i5 && i < i2 && i2 < i3 && i3 < i4 && i4 < i5)  
                                    {
                                        Console.WriteLine($"{i} {i2} {i3} {i4} {i5}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
