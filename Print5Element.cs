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
    // Output to console 5th array element

    class Program
    {
        static void Main()
        {
            // Declaring and initializing a 6-elements array 

            int[] myArray = { 1, 4, 6, 2, 6, 8 };

            int num5 = myArray[4];

            Console.WriteLine(num5);
        }

    }

}
