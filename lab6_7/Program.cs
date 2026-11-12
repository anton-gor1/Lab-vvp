using System;

class Program
{
    /// <summary>
    /// Ищет член последовательности, удовлетворяющий заданному условию.
    /// </summary>
    static void Main()
    {
        Console.Write("Введите колличество итераций m: ");
        int maxIterations = Convert.ToInt32(Console.ReadLine());

        if (maxIterations <= 0)
        {
            Console.WriteLine("m должно быть положительным числом.");
            return;
        }

        double currentValue = 0.1;
        int memberNubmer = 1;

        // Вычисляем следующие члены и проверяем модуль каждого из них.
        for (int iteration = 0; iteration < maxIterations; iteration++)
        {
            currentValue = Math.Tan(currentValue) / 2;
            memberNubmer++;

            if (Math.Abs(currentValue) < 0.001)
            {
                Console.WriteLine($"Условие выполнено для члена a_{memberNubmer}.");
                return;
            }
        }
        Console.WriteLine($"За {maxIterations} оборотов цикла условие не достигнуто.");
    }
}