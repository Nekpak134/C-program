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
            for(int i = 0; i <=100; i++)
            {
                if(i%2==0)
               Console.WriteLine(i);
            }
            Console.ReadLine();

           /* Console.WriteLine("enter the no to test");
            int i=Convert.ToInt32(Console.ReadLine());
            if(i%2==0)
            {
                Console.WriteLine("Even no");
            }
            else
            {
                Console.WriteLine("odd no");
            }
            Console.ReadLine();*/
        }
    }
}
