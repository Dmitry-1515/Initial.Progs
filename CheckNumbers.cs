// See https://aka.ms/new-console-template for more information
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Practice
{
    // Write code: user input 2 numbers.The numbers will be compared
    // with the following output to console of the comparison result
    // (are values equal, and if not, what number is more or less).

    class Program
    {
        static void Main()
        {
            // Input two numbers

            string data = Console.ReadLine();

            string data1 = Console.ReadLine();

            // Declare two variables and initialise them by method Parse
            
            int a = int.Parse(data);

            int b = int.Parse(data1);

            // Check numbers

            if (a == b)

            {
                Console.WriteLine("a = b");
            }

            if (a > b)

            {
                Console.WriteLine("a > b");
            }

            if (a < b)

            {
                Console.WriteLine("a < b");
            }

        }

    }

}
