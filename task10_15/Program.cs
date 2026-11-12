using System;

class Program
{
    /// <summary>
    /// Сортирует массив целых чисел по убыванию методом простых вставок.
    /// </summary>
    /// <param name="numbers">Массив для сортировки.</param>
    static void SortByInsertionDescending(int[] numbers)
    {
        for (int currentIndex = 1; currentIndex < numbers.Length; currentIndex++)
        {
            int currentNumber = numbers[currentIndex];
            int previousIndex = currentIndex - 1;

            while (previousIndex >= 0 && numbers[previousIndex] < currentNumber)
            {
                numbers[previousIndex + 1] = numbers[previousIndex];
                previousIndex--;
            }

            numbers[previousIndex + 1] = currentNumber;
        }
    }

    /// <summary>
    /// Ищет число в массиве линейным поиском.
    /// </summary>
    /// <param name="numbers">Массив для поиска.</param>
    /// <param name="searchNumber">Искомое число.</param>
    /// <returns>Индекс найденного числа или -1, если число не найдено.</returns>
    static int LinearSearch(int[] numbers, int searchNumber)
    {
        for (int index = 0; index < numbers.Length; index++)
        {
            if (numbers[index] == searchNumber)
            {
                return index;
            }
        }

        return -1;
    }

    /// <summary>
    /// Выводит элементы массива на экран.
    /// </summary>
    /// <param name="numbers">Массив для вывода.</param>
    static void PrintArray(int[] numbers)
    {
        foreach (int number in numbers)
        {
            Console.Write($"{number} ");
        }

        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Введите количество элементов массива: ");
        int elementCount = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[elementCount];

        for (int index = 0; index < numbers.Length; index++)
        {
            Console.Write($"Введите элемент массива [{index}]: ");
            numbers[index] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nИсходный массив:");
        PrintArray(numbers);

        SortByInsertionDescending(numbers);

        Console.WriteLine("\nМассив после сортировки по убыванию:");
        PrintArray(numbers);

        Console.Write("\nВведите число для поиска: ");
        int searchNumber = Convert.ToInt32(Console.ReadLine());

        int foundIndex = LinearSearch(numbers, searchNumber);

        if (foundIndex >= 0)
        {
            Console.WriteLine(
                $"Число {searchNumber} найдено. Индекс в массиве: {foundIndex}.");
        }
        else
        {
            Console.WriteLine($"Число {searchNumber} не найдено.");
        }
    }
}