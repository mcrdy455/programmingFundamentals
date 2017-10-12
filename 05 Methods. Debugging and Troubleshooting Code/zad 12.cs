using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp8
{

    class Program
    {
        static bool Symmetric(int a)
        {
            string a2 = Convert.ToString(a);
            string sym = String.Empty;
            
            for (int i = 1; i <= a2.Length; i++)
            {
                sym += a2[a2.Length - i];
            }
            if (sym == a2) return true;
            return false;
        }
        static bool Divisible(int a)
        {
            
            int sum = a%10;
            for (int i = 1; i <= Convert.ToString(a).Length; i++)
            {
                sum += a / (int)Math.Pow(10, i) % 10;
            }
            if (sum % 7 == 0) return true;
            return false;
        }
        static bool Even(int a)
        {
            
            if (Convert.ToString(a).Contains('0') || Convert.ToString(a).Contains('2') || Convert.ToString(a).Contains('4') || Convert.ToString(a).Contains('6') || Convert.ToString(a).Contains('8'))
            {
                return true;
            }
            return false;
        }


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (Symmetric(i) && Divisible(i) && Even(i)) 
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}
