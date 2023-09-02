// Calculate a sum of figures in a number

// Вводим число

Console.Write("Число = ");

int num = int.Parse(Console.ReadLine());

// Объявляем переменную для суммы и переменные для вычислений

float sum = 0;

float num1 = 0;

int num2 = num;

int i = 0;

// Считаем количество цифр в числе

while (num2 > 0)

    {
        i++;
        num2 /= 10;
    }

        Console.WriteLine($"Количество цифр = {i}");

// Считаем сумму цифр числа

while (i > 0)
    {
        num1 = num % 10;
        sum = sum + num1;
        num = num / 10;
        i--;
    }

Console.WriteLine($"Сумма цифр = {sum}");

Console.ReadLine();

