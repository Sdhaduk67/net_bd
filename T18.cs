using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_bd
{
    internal class T18
    {
        static void Main(string[] args) //defining Main method
        {
            int number = 1;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number + " ");
                    number++; // Go to next number
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }

    }
}
