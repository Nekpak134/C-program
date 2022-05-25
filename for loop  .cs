using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* for(int i = 0; i <=100; i++)
             {
                 Console.WriteLine(i);
             }
                Console.ReadLine();*/

            Console.WriteLine("i j");
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    Console.WriteLine(i + " " + j);
                }
            }
            Console.ReadLine();
            
        }
    }
}
