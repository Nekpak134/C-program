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

            string s1 = "welcom to chetu";
            string s2 = "";
            foreach(var  item in s1)
            {
                s2 = item + s2;

            }
            Console.WriteLine(s2);
            Console.ReadLine();
        }
    }
}
