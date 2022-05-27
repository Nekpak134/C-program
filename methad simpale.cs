using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
     class Program
    {
        public void m1()
        {
            Console.WriteLine("methad");
        }
        public static void Main(string[] args)
        {
            Program m = new Program();
            m.m1();
           Console.ReadLine();
        }
    }
}
