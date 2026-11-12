using System;

/// <summary>
/// Считывает число N и выводит сумму первых N целых положительных чисел.
/// </summary>
class Program
{
    static void Main()
    {
        Console.Write("Введите число N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Складываем числа от 1 до N
        long sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        Console.WriteLine($"Сумма первых {n} целых положительных чисел равна: {sum}");
    }
}