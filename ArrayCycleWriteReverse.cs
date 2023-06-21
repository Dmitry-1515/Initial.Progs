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
        // Вывести на консоль элементы массива при помощи рекурсии
        
        static void Main()
        {
            // Объявляем и инициализируем массив

            int[] myArray = { 1, 4, 6, 2, 5 };

            Console.WriteLine("\nВывод массива:");

            // Запускаем цикл for, проходя массив в обратном порядке

            for (int i = myArray.Length; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.ReadLine();
        }

    }

}
