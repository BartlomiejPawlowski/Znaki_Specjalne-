using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znaki_Specjalne
{
    internal class Program
    {
       
        static void Main(string[] args)
        {   //ćwiczenie 6.1 str 49
            double a = 14.5;
            double b = 24.45;
            Console.Write("{0}\n"+"{1}\n", a, b);
            
            //Ćwiczenie 6.2 str 49
            Console.WriteLine(" /---\\\t|----\\\t/----\\");
            Console.WriteLine("|     |\t|    |\t|");
            Console.WriteLine("|     |\t|    /\t|");
            Console.WriteLine("|-----|\t|---- \t|");
            Console.WriteLine("|     |\t|    \\\t|");
            Console.WriteLine("|     |\t|    |\t|");
            Console.WriteLine("|     |\t|----/\t\\----/");

            //Ćwiczenie 6.3 str 49
            Console.WriteLine("111\t+\t222\t=\t333\n" + " + \t\t + \t\t +\n" + "333\t+\t444\t=\t777\n" + " = \t\t = \t\t =\n" + "444\t+\t666\t=\t1110\n");

            Console.ReadKey();  
        }
    }
}
