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
            int number = 121;
            int rem;
            int result = 0;
            int temp = number;
            while (number != 0) 
            {
                rem = number % 10;
                result = result * 10 + rem;
                number = number / 10;
            }
            number = temp;
                if(number == result)
            {
                Console.WriteLine("palindrome no");
            }
                else
            {
                Console.WriteLine("not palindrom no");
            }
            Console.ReadLine();

            
        }
    }
}
