using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    class Program
    {
        void N1(int a)
        {
            Console.WriteLine("nekpal: "+a);
        }
        void N1(int a,int b)
        {
            Console.WriteLine("nekpal: "+a+ "and "+b);
        }
        static void Main(string[]args)
        {
            Program obj = new Program();
               obj.N1(20);
               obj.N1(10,20);
            Console.ReadLine();
        }
    }
}
            
        
    

