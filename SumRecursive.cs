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
    // Output the elements sum of an array using the recursion method

    class Program
    {
        // Declare and describe Sum recursive method

        static int Sum(int[] myArray, int i = 0)
        {
            // Interrupt condition

            if (i >= myArray.Length)
                return 0;

            return myArray[i] + Sum(myArray, i + 1);

        }

        static void Main()
        {
            // Declarу and initialize a 6-elements array 

            int[] myArray = { 1, 4, 6, 2, 6, 8 };

            // Use the Sum method

            int result = Sum(myArray);

            Console.WriteLine(result);
        }

    }

}
