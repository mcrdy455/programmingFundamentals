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


            string a = Console.ReadLine();
            string msg = "";
            switch (a)
            {
                case "a":
                case "e":
                case "u":
                case "o":
                case "i":
                case "y":
                    msg = "vowel";
                    break;
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    msg = "digit";
                    break;
                default:
                    msg= "other";
                    break;
            }
            Console.WriteLine(msg);
        }
    }
}
