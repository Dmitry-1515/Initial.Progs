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
        static void Main()
        {
            // Вводим число с консоли
            double number = double.Parse(Console.ReadLine());

            // Объявляем переменную result для вывода результата в нужном формате
            string result = string.Format("{0:f2}", number);

            Console.WriteLine("Число равно " + result);
        }

    }

}
