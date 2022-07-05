using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    class Program
    {
        public static void Main(string[] args)
        {


            {
                int i = 5;
                while (i >= 1)
                {
                    int j = 5;
                    while (j >= i)
                    {
                        Console.Write(j);
                        j--;
                    }
                    i--;
                    Console.WriteLine();
                }
                Console.Read();
            }

            Console.ReadLine();
        }
    }
}
            
        
    

