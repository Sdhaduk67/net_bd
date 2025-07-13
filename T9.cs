using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_bd
{
    internal class T9
    {
        static void Main(string[] args) //defining Main method
        {
            Console.WriteLine("Enter a name:");
            string input = Console.ReadLine();
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (char.IsUpper(ch))
                    result += char.ToLower(ch);  // Upper to lower
                else if (char.IsLower(ch))
                    result += char.ToUpper(ch);  // Lower to upper
                else
                    result += ch;
            }
            Console.WriteLine("Output: " + result);
        }

    }
}
