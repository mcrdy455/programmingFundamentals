using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());
            int cal = 0;
            for (int i = 0; i < count; i++)
            {
                string ing = Console.ReadLine();
                ing = ing.ToLower();
                switch (ing)
                {
                    case "cheese":
                        cal += 500;
                        break;
                    case "tomato sauce":
                        cal += 150;
                        break;
                    case "salami":
                        cal += 600;
                        break;
                    case "pepper":
                        cal += 50;
                        break;
                            
                }
            }
            Console.WriteLine($"Total calories: {cal}");

        }
    }
}

//
