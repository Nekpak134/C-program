using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int[] mynumber = { 1, 4, 3, 5, 6, 7 };
             Array.Sort(mynumber);
             foreach (int i in mynumber)
             {
                 Console.WriteLine(i);
             }

                 Console.ReadLine();*/
            int[] mynumber = { 5, 9, 10, 7, 8 ,9};
            Console.WriteLine(mynumber .Max());
            Console.WriteLine(mynumber.Min());
            Console.WriteLine(mynumber.Sum());
            Console.ReadLine();

            
        }
    }
}
