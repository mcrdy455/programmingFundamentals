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
            var info = Console.ReadLine();
            int n;
            int sum = 0;
            bool isNumeric = int.TryParse(info, out n);
            while (isNumeric)
            {
                info = Console.ReadLine();
                isNumeric = int.TryParse(info, out n);
                sum++;

            } 
Console.WriteLine(sum);

        }
    }
}
