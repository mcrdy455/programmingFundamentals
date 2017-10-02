using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp8
{
   
    class Program
    {

        static void Main(string[] args)
        {
            

            int n = int.Parse(Console.ReadLine());
            int n2 = n;
            string bin= "";
            while (n > 0)
            {
                bin += $"{n % 2}";
                n /= 2;

            }
            string output = "";
            for (int i = bin.Length - 1; i >= 0; i--)
            {
                output += bin[i];
            }
            Console.WriteLine(string.Format("{0:X}", n2));
            Console.WriteLine(output);

            /* 96%2 =0
             * 48%2=0
             * 24%2=0
             * 12%2=0
             * 6%2=0
             * 3%2=1
             * 1%2=1*/
             
        }
    }
}
