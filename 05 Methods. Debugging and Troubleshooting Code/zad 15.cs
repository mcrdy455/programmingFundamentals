using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;




public class Substring_broken
{
    public static void Main()
    {
        char[] text = Console.ReadLine().ToCharArray();
        int jump = int.Parse(Console.ReadLine());
        
        const char Search = 'p';
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == Search)
            {
                hasMatch = true;

                int endIndex = jump+1;

                if (endIndex > text.Length-i)
                {
                    endIndex = text.Length - i;
                }

                char[] matchedString = new char[endIndex];
                for (int j = 0; j < endIndex; j++)
                {
                    matchedString[j] = text[i + j];
                }
                Console.WriteLine(string.Join("",matchedString));
                i += jump;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
