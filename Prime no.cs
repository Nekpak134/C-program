using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 7;
            int count = 0;
            for (int i = 1; i <=num; i++)
            {
                if (num% i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("prime no");
            }
            else
            {
                Console.WriteLine("not a prime no");
            }       
                    Console.ReadLine();
                
            
        }
    }
}
    

