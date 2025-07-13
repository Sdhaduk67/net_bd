using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_bd
{
    internal class T16
    {
        static void Main(string[] args) //defining Main method
        {
            {
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }
    }
}
