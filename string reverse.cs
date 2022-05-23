using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any string");
            string s = Console.ReadLine();
            Console.Write("reverse string =");
            for(int i =(s.Length-1);i>=0; i--)
            {
                Console.Write(s[i]);
            }
             
            Console.ReadLine();

            
        }
    }
}
