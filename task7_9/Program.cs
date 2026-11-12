using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите колличество элементов массива N: ");
        int arrayLength = Convert.ToInt32(Console.ReadLine());

        if (arrayLength <= 0)
        {
            Console.WriteLine("N должно быть положительным числом");
            return;
        }

        int[] numbers = new int[arrayLength];

        // Вводим элементы массива и считаем числа, кратные трем.
        int divisibleByThreeCount = 0;

        for (int index = 0; index < arrayLength; index++)
        {
            Console.Write($"Введите элемент {index + 1}: ");
            numbers[index] = Convert.ToInt32(Console.ReadLine());

            if (numbers[index] % 3 == 0)
            {
                divisibleByThreeCount++;
            }
        }
        Console.WriteLine($"Колличество элементов, кратных 3: {divisibleByThreeCount}");
    }
}