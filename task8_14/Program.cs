using System;

class Program
{
    /// <summary>
    /// Делит все элементы матрицы на наибольший модуль её элементов.
    /// </summary>
    static void Main()
    {
        Console.Write("Введите колличество строк n: ");
        int rowCount = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите колличество столбцов m: ");
        int columnCount = Convert.ToInt32(Console.ReadLine());

        if (rowCount <= 0 || columnCount <= 0)
        {
            Console.WriteLine("Размеры матрицы должныть быть полоижтельными");
            return;
        }

        double[,] matrix = new double[rowCount, columnCount];
        double maxAbsoluteValue = 0;

        // Считываем элементы и одновременно находим наибольший модуль.
        for (int row = 0; row < rowCount; row++)
        {
            for (int column = 0; column < columnCount; column++)
            {
                Console.Write($"Введите элемент [{row + 1}, {column + 1}]: ");
                matrix[row, column] = Convert.ToDouble(Console.ReadLine());

                double absoluteValue = Math.Abs(matrix[row, column]);

                if (absoluteValue > maxAbsoluteValue)
                {
                    maxAbsoluteValue = absoluteValue;
                }
            }
        }

        if (maxAbsoluteValue == 0)
        {
            Console.WriteLine("Матрица состоит из нулей. Деление невозможно.");
            return;
        }

        // Делим каждый элемент матрицы на найденный максимальный модель.
        for (int row = 0; row < rowCount; row++)
        {
            for (int column = 0; column < columnCount; column++)
            {
                matrix[row, column] /= maxAbsoluteValue;
            }
        }

        Console.WriteLine("Новая матрица: ");
        for (int row = 0; row < rowCount; row++)
        {
            for (int column = 0; column < columnCount; column++)
            {
                Console.Write($"{matrix[row, column],8:F3}");
            }
            Console.WriteLine();
        }
    }
}