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
          /*for(int i = 0; i <=10; i++)
            {
                Console.WriteLine(i);
                if (i == 7)
                    break;
            }
            Console.WriteLine("after the loop");
            Console.ReadLine();*/


            for(int i = 0; i <=10; i++)
            {
                
                if (i == 8)
                    continue;
                Console.WriteLine(i);
            }
            Console.WriteLine("after the loop");
            Console.ReadLine();
            
        }
    }
}
