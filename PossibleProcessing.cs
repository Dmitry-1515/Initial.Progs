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
    // Проверка допустимости преобразования

    class Program
    {
        static void Main()
        {
            // Извлечение квадратного корня из данных

            Sqrt("12"); // Квадратный корень из числа 12: 3,464...

            Sqrt("ab"); // Некорректный ввод

            // Проверка данных на допустимость преобразования

            void Sqrt(string data)
            {
                // Если можно преобразовать данное в формат double,
                // то метод TryParse возвращает переменную х в формате double

                if (double.TryParse(data, out var x))
                {
                    // Переменной i присваивается квадратный корень из х

                    double i = Math.Sqrt(x);

                    // Переменная i выводится на консоль с точностью до тысячных

                    Console.WriteLine($"Квадратный корень числа {x}:  {i:f3}");
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }
        }

    }

}
