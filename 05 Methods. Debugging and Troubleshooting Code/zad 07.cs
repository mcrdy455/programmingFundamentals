using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp8
{
   
    class Program
    {
        static string Prime(long a)
        {
            long b = (long)Math.Sqrt(a);
            string prime= "";
            if (a == 0 || a == 1) return "False";
            else if (a == 2||a==3) return "True";
            else
            {
                for (long i = 2; i <= b; i += 1)
                {
                    if (a % i == 0)
                    {
                        prime = "False";
                        break;
                    }
                    else
                    {
                        prime = "True";
                    }
                }
            }
            return prime;
        }
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            int notFirst = 0;
            for (long i = a; i <= b; i++)
            {
                
                if(Prime(i)=="True"&& notFirst==0)
                {
                    Console.Write($"{i}");
                    notFirst++;
                }
                else if (Prime(i) == "True" && notFirst == 1)
                {
                    Console.Write($", {i}");
                }

            }
            
            
        }
    }
}
