using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string mon = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            double std = 0;
            double dbl = 0;
            double su = 0;
            int free = 0;
            switch (mon)
            {
                case "May":
                case "October":
                    std = 50;
                    dbl = 65;
                    su = 75;
                    break;
                case "June":
                case "September":
                    std = 60;
                    dbl = 72;
                    su = 82;
                    break;
                case "July":
                case "August":
                case "December":
                    std = 68;
                    dbl = 77;
                    su = 89;
                    break;
            }
            if ((mon == "May" || mon == "October") && n>7)
            {
                std = std * 0.95;
            }
            if ((mon == "June" || mon == "September") && n > 14)
            {
                dbl = dbl * 0.9;
            }
            if ((mon == "July" || mon == "August" || mon == "December") && n > 14)
            {
                su = su * 0.85;
            }
            if ((mon == "September" || mon == "October") && n > 7)
            {
                free = n / 7;
            }
            Console.WriteLine($"Studio: {std*(n-free):f2} lv.");
            Console.WriteLine($"Double: {dbl*n:f2} lv.");
            Console.WriteLine($"Suite: {su*n:f2} lv.");
        }
    }
}
