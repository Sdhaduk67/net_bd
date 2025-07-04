using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_bd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : 1");
            //type casting
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number : 2");
            int b = int.Parse(Console.ReadLine());

            //string interploation
            Console.WriteLine($"sum of {a} + {b} number is :" + (a + b));
        }
    }
}
