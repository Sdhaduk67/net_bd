using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_bd
{
    internal class T11
    {
        static void Main(string[] args) //defining Main method
        {

            // Ask for name
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            // Ask for gender
            Console.Write("Enter Gender (M/F): ");
            string gender = Console.ReadLine();

            // Check and display with prefix
            if (gender == "M" || gender == "m")
            {
                Console.WriteLine("Mr. " + name);
            }
            else if (gender == "F" || gender == "f")
            {
                Console.WriteLine("Ms. " + name);
            }
            else
            {
                Console.WriteLine("Invalid gender.");
            }
        }

    }
}
