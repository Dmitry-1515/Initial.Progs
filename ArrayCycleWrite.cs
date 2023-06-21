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
    class Program
    {
        // Вывести на консоль элементы массива при помощи цикла
        
        static void Main()
        {
            // Объявляем и инициализируем массив

            int[] myArray = { 1, 4, 6, 2, 5 };

            Console.WriteLine("\nВывод массива:");

            // Запускаем цикл for

            for (int i = 0; i <= myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.ReadLine();
        }

    }

}
