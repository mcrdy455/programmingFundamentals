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
            double pdmg = double.Parse(Console.ReadLine());
            double gdmg = double.Parse(Console.ReadLine());
            double php = 100;
            double ghp = 100;
            int round = 0;
            while (php>0 && ghp>0)
            {
                round++;
                if (round%2==1)
                {
                    ghp -= pdmg;
                    if (ghp <= 0) { break; }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {ghp} health.");
                }
                else
                {
                    php -= gdmg;
                    if (php <=0) { break; }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {php} health.");
                }
                if (round % 3 == 0)
                {
                    php += 10;
                    ghp += 10;
                }
                
            }
            if (ghp <= 0) { Console.WriteLine($"Pesho won in {round}th round."); }
            else { Console.WriteLine($"Gosho won in {round}th round."); }
        }
    }
}
