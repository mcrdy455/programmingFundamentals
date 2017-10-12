using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp8
{
   
    class Program
    {
        static string Reverce(string a)
        {
            string rev = String.Empty;
            for (int i = 1; i <= a.Length; i++)
            {
                rev += a[a.Length-i];
            }
            return rev;
        }
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            Console.WriteLine(Reverce(a));
        }
    }
}
