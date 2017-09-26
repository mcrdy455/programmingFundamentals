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
            var word = Console.ReadLine();
            bool y = word.EndsWith("y");
            if (y)
            {
                word = word.TrimEnd('y');
                Console.Write(word + "ies");
            }
            else if (word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s") || word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z"))
            {
                Console.Write(word + "es");
            }
            else { Console.Write(word + "s"); }
        }
    }
}
