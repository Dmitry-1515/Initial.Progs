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
        static int Sum(int[] myArray, int i = 0)
        {
            if (i >= myArray.Length)
                return 0;

            return myArray[i] + Sum(myArray, i + 1);

        }

        static void Main()
        {
            // Declaring and initializing a 5-elements array 

            int[] myArray = { 1, 4, 6, 2, 6, 8 };

            int result = Sum(myArray);

            Console.WriteLine(result);
        }

    }

}
