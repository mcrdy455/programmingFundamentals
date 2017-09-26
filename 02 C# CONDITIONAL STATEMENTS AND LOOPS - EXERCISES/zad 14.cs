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
            char n = char.Parse(Console.ReadLine());
            char m = char.Parse(Console.ReadLine());
            char x = char.Parse(Console.ReadLine());

            int nn = Convert.ToInt32(n) - 96;
            int mm = Convert.ToInt32(m) - 96;
            int xx = Convert.ToInt32(x) - 96;
            int err = 0;
            for (int i = nn; i <= mm; i++)
            {
                if (i==xx && i<=mm ) { goto asd; }
                
                for (int k = nn; k <= mm; k++)
                {
                    if (k == xx && k<=mm ) { goto bsd; }
                    
                    for (int u = nn; u <= mm; u++)
                    {
                        if (u == xx && u<=mm ) { goto csd; }
                        
                        Console.Write($"{Convert.ToChar(i+96)}{Convert.ToChar(k+96)}{Convert.ToChar(u+96)} ");
                        csd: err++;
                    }
                    bsd: err++;
                }
                asd: err++;
            }


        }
    }
}
