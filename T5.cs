using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_bd // Program Namespace
{
    internal class T5 // Main Class
    {
        static void Main(string[] args) // Main Method

        {

            int n, fact = 1; // Declare n and set fact = 1

            Console.WriteLine("Enter Number : "); // ask user to enter number

            string str = Console.ReadLine(); // Read input as string

            n = Convert.ToInt32(str); // Convert string to integer

            for (int i = 1; i <= n; i++) // Loop from 1 to n

            {

                fact = fact * i; // Multiply to get factorial

            }

            Console.WriteLine("Factorial : {0}", fact); // Show Result



            Console.Read(); // Wait key press

        }
    }
}
