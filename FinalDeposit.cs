/* For each month, the bank accrues 7% of the amount to the deposit amount.
   Write a console program where the user enters the deposit amount and the number of months. 
   Calculate the final amount of the deposit. */


// Вводим количество месяцев и величину начального депозита

Console.Write("Количество месяцев депозита = ");

int month = Convert.ToInt32(Console.ReadLine());

Console.Write("Начальный депозит = ");

decimal deposit = Convert.ToDecimal(Console.ReadLine());

decimal percents = Deposit * 7 / 100;

for (int m = 1; m <= month; m++)

    {
        deposit += percents;
    }

        Console.WriteLine($"Конечный депозит = {deposit}");

Console.ReadLine();

