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
           

            Console.WriteLine("enter the no to test");
            int i=Convert.ToInt32(Console.ReadLine());
            if(i>=100)
            {
                Console.WriteLine("a greade");
            }
            else if (i>=80)
            {
                Console.WriteLine("b greade");
            }
            else if (i>=50)
            {
                Console.WriteLine("c greade ");
            }
            else
            {
                Console.WriteLine("fal");
            }
               Console.ReadLine();
        }
    }
}
