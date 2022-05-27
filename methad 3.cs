using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
     class Program
    {
       /* public void mymethad(int i, int j)
        {
            int result = i + j;
            Console.WriteLine(result);
            
        }
        public static void Main(string[] args)
        {
            Program m = new Program();
             m.mymethad(90, 90);
           Console.ReadLine();*/
        static void mymethad(string neme,int age)
        {
            Console.WriteLine(neme+"is "+age);
        }
        static void Main(string[]args)
        {
            mymethad("nekpal ", 20);
            mymethad("rihan ", 22);
            Console.ReadLine();

        }
    }
}
