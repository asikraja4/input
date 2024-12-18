using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter 0 or 1: ");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("True");
            }
            else if (input == "0")
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
