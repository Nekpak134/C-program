using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    class program
    {
        void M1(string x)
        {
            Console.WriteLine("nekpal: " + x);
        }
        void M1(string y, string z)
        {
            Console.WriteLine("nekpal: " + y  + z);
        }
        static void Main(string[] args)
        {
            program obj = new program();
                  obj.M1("rahul");
            obj.M1("raju  ", "sachin");
            Console.ReadLine();
        }

    }
}
            
        
    

