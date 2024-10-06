using System;

class Program
{
    static void Main()
    {
        // Ввод трехзначного числа
        Console.Write("Введите трехзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Проверка, является ли число трехзначным
        if (number < 100 || number > 999)
        {
            Console.WriteLine("Число должно быть трехзначным.");
            return;
        }

        // Вычисление обратного порядка числа
        int reversed = 0;
        while (number > 0)
        {
            reversed = reversed * 10 + number % 10;
            number /= 10;
        }

        // Вывод результата
        Console.WriteLine("Обратный порядок числа: " + reversed);
    }
}
