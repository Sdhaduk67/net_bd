using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_bd
{
    internal class T10
    {
        static void Main(string[] args) //defining Main method
        {
            Console.Write("Enter Mobile Number: ");
            string number = Console.ReadLine();
            if (number.Length >= 5)
            {
                string visible = number.Substring(0, number.Length - 5); // First part
                string masked = "XXXXX"; // Last 5 digits replaced

                Console.WriteLine("Output: " + visible + masked);
            }
            else
            {
                Console.WriteLine("Please enter at least 5 digits.");
            }
        }

    }
}
