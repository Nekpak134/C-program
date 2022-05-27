using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cars = new List<string>();
            cars.Add("nekpal");
            cars.Add("rihan");
            cars.Add("sachin");
            cars.Add("nadim");
            foreach (string car in cars)
            //for (int i = 1; i <= cars.Count; i++)
            {
                 Console.WriteLine(car);
            }
                Console.ReadLine();
            

        }
    }
}
