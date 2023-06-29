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
    // Создаём класс Student со своими полями

    class Student
    {
        public string Name;
    }
    
    class Program
    {
        static Student GetStudent()
        {
            // Объявляем объект класса Student
            
            var student = new Student();

            // Присваиваем полю объекта значение

            student.Name = "Мартын";

            // Возвращаем объект student

            return student;
        }
        
        static void Main()
        {
            // Объявляем объект класса Student

            var firstStudent = GetStudent();

            Print(firstStudent);
        }

    }

}
