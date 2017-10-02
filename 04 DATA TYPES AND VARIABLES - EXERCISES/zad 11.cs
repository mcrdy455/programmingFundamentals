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
            long cent = long.Parse(Console.ReadLine());
            long sec = (long)(36524.22 * cent) * 24 * 60 * 60;
            
            Console.WriteLine($"{cent} centuries = {100*cent} years = {(long)(36524.22*cent)} days = {(long)(36524.22 * cent )*24} hours = {(long)(36524.22 * cent)*24*60} minutes = {sec} seconds = {$"{sec}000"} milliseconds = {$"{sec}000000"} microseconds = {$"{sec}000000000"} nanoseconds");
        }
    }
}
