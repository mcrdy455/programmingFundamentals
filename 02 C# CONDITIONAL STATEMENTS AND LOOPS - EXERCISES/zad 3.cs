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
            int n = int.Parse(Console.ReadLine());
            string pack = Console.ReadLine();
            double price = 0;
            if (n <= 50)
            {
                Console.WriteLine("We can offer you the Small Hall");
                price = 2500;
                switch (pack)
                {
                    case "Normal":
                        price = (price + 500) * 0.95;
                        break;
                    case "Gold":
                        price = (price + 750) * 0.9;
                        break;
                    case "Platinum":
                        price = (price + 1000) * 0.85;
                        break;
                }
            }
            else if (n > 50 && n <= 100)
            {
                Console.WriteLine("We can offer you the Terrace");
                price = 5000;
                switch (pack)
                {
                    case "Normal":
                        price = (price + 500) * 0.95;
                        break;
                    case "Gold":
                        price = (price + 750) * 0.9;
                        break;
                    case "Platinum":
                        price = (price + 1000) * 0.85;
                        break;
                }
            }
            else if (n>100&& n<=120)
            {
                Console.WriteLine("We can offer you the Great Hall");
                price = 7500;
                switch (pack)
                {
                    case "Normal":
                        price = (price + 500) * 0.95;
                        break;
                    case "Gold":
                        price = (price + 750) * 0.9;
                        break;
                    case "Platinum":
                        price = (price + 1000) * 0.85;
                        break;
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            Console.WriteLine($"The price per person is {price / n:f2}$");

        }
    }
}
