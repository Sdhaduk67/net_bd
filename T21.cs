using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_bd
{
    internal class T21
    {
        static void Main(string[] args) //defining Main method
        {
            Console.Write("Enter number of terms: ");
            int terms = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a single digit number: ");
            int digit = Convert.ToInt32(Console.ReadLine());

            int currentNumber = 0;
            int total = 0;  // Sum of all numbers

            Console.Write("Series: ");

            for (int i = 1; i <= terms; i++)
            {
                // Build the current number
                currentNumber = currentNumber * 10 + digit;

                Console.Write(currentNumber);

                // Print + sign between numbers
                if (i != terms)
                    Console.Write(" + ");

                total = total + currentNumber;
            }
            Console.WriteLine();
            Console.WriteLine("The Sum is: " + total);
        }

    }
}
