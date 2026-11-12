using System;

class Program
{
    /// <summary>
    /// Возвращает большее из двух чисел.
    /// Параметры передаются по значению.
    /// </summary>
    /// <param name="firstNumber">Первое число.</param>
    /// <param name="secondNumber">Второе число.</param>
    /// <returns>Большее из двух чисел.</returns>
    static double Max(double firstNumber, double secondNumber)
    {
        if (firstNumber > secondNumber)
        {
            return firstNumber;
        }

        return secondNumber;
    }

    /// <summary>
    /// Записывает большее из двух чисел в переменную result,
    /// переданную по ссылке.
    /// </summary>
    /// <param name="firstNumber">Первое число.</param>
    /// <param name="secondNumber">Второе число.</param>
    /// <param name="result">Переменная для результата.</param>
    static void MaxByReference(
        double firstNumber,
        double secondNumber,
        ref double result)
    {
        if (firstNumber > secondNumber)
        {
            result = firstNumber;
        }
        else
        {
            result = secondNumber;
        }
    }

    static void Main()
    {
        Console.Write("Введите число a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите число b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите число c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите число d: ");
        double d = Convert.ToDouble(Console.ReadLine());

        // Вычисления с передачей параметров в Max по значению.
        double x = Max(a, b);
        double y = Max(c, d);
        double z = Max(x, y);

        Console.WriteLine();
        Console.WriteLine("Передача параметров по значению:");
        Console.WriteLine($"x = max(a, b) = {x}");
        Console.WriteLine($"y = max(c, d) = {y}");
        Console.WriteLine($"z = max(x, y) = {z}");

        // Вычисления с передачей результата по ссылке.
        double xByReference = 0;
        double yByReference = 0;
        double zByReference = 0;

        MaxByReference(a, b, ref xByReference);
        MaxByReference(c, d, ref yByReference);
        MaxByReference(xByReference, yByReference, ref zByReference);

        Console.WriteLine();
        Console.WriteLine("Передача результата по ссылке:");
        Console.WriteLine($"x = max(a, b) = {xByReference}");
        Console.WriteLine($"y = max(c, d) = {yByReference}");
        Console.WriteLine($"z = max(x, y) = {zByReference}");
    }
}