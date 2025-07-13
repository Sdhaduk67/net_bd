using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_bd
{
    internal class T20
    {
        static void Main(string[] args) //defining Main method
        {
            int number = 1;

            for (int i = 1; i <= 4; i++)
            {
                // Print spaces to numbers to the right
                for (int space = 1; space <= 4 - i; space++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number + " ");
                    number++;
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

    }
}
