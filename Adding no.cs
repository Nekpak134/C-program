using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 20;
            if (time < 20)
            {
                Console.WriteLine("Good morning");
            }
            else if (time <10)
            {
                Console.WriteLine("good eveing");

            }
            else
            {
                Console.WriteLine("good nt");
            }
            Console.ReadLine();
        }
    }
}
