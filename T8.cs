using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_bd
{
    internal class T8
    {
        static void Main(string[] args) //defining Main method
        {
            Console.WriteLine("Enter a name:");
            string name = Console.ReadLine();
            string upperName = name.ToUpper();
            Console.WriteLine("Output: " + upperName);
            Console.Read();
        }

    }
}
