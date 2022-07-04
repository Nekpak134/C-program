using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main(string[] args)
        {
            {
                int x, y, z;
                for (x = 1; x <= 8; x++)
                {
                    for (y = 1; y <= x; ++y)
                        Console.Write(y);

                    for (z = 8 - x; z >= 1; z--)
                        Console.Write("*");

                    Console.WriteLine();
                }


                Console.ReadLine();
            }
        }
    }
}
