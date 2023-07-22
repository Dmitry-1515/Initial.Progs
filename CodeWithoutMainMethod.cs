namespace Practice
{
    // Create class Student and print object parameters

    // Создаём класс Student со своими полями

    class Student
    {
        public string Name;
    }

    class Program
    {
        // Записываем метод для присвоения объекту значения 
        static Student GetStudent()
        {
            // Объявляем объект класса Student

            var student = new Student();

            // Присваиваем полю объекта значение

            student.Name = "Степан";

            // Возвращаем объект student

            return student;
        }

        // Записываем метод для печати значения объекта 
        static void Print(Student student)
        {
            // Печать значений объекта

            Console.WriteLine(student.Name);
        }
        static void Main()
        {
            // Объявляем объект класса Student

            var firstStudent = GetStudent();

            // Печатаем данные объекта

            Print(firstStudent);
        }

    }

}
