using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_bd
{
    internal class T13
    {
        static void Main(string[] args) //defining Main method
        {

            int a = 0, b = 1, c;
            // Print the first two numbers
            Console.Write(a + " ");
            Console.Write(b + " ");

            // Print next 9 numbers to make 11 total
            for (int i = 1; i <= 9; i++)
            {
                c = a + b;        // Add previous two numbers
                Console.Write(c + " ");

                a = b;            // Shift values
                b = c;
            }
            Console.WriteLine();
        }

    }
}
