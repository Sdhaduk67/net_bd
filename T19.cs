using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_bd
{
    internal class T19
    {
        static void Main(string[] args) //defining Main method
        {
            int rows = 4;

            for (int i = 1; i <= rows; i++)
            {
                // Print spaces before stars
                for (int s = 1; s <= rows - i; s++)
                {
                    Console.Write(" ");
                }

                // Print stars with space after each
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
                Console.WriteLine();

            }
        }

    }
}
