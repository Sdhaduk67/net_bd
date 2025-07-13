using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_bd
{
    internal class T15
    {
        static void Main(string[] args) //defining Main method
        {
            Console.Write("Enter a number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            int originalNumber = inputNumber;
            int digitCount = inputNumber.ToString().Length; // Count how many digits are in the number

            int sum = 0; // This will store the sum of digits raised to power

            while (inputNumber > 0)
            {
                int digit = inputNumber % 10; // Get the last digit

                int power = 1;
                for (int i = 1; i <= digitCount; i++)
                {
                    power = power * digit;
                }
                sum = sum + power; // Add the result 

                inputNumber = inputNumber / 10; // Remove the last digit from number
            }
            // Check if the sum is equal to the original number
            if (sum == originalNumber)
            {
                Console.WriteLine("It is an Armstrong number.");
            }
            else
            {
                Console.WriteLine("It is not an Armstrong number.");
            }
        }

    }
}
