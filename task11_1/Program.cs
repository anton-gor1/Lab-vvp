using System;

class Program
{
    /// <summary>
    /// Вычисляет n-й член геометрической прогрессии.
    /// </summary>
    /// <param name="firstTerm">Первый член прогрессии.</param>
    /// <param name="ratio">Знаменатель прогрессии.</param>
    /// <param name="termNumber">Номер члена.</param>
    /// <returns>Значение n-го члена.</returns>
    static double GetTerm(double firstTerm, double ratio, int termNumber)
    {
        if (termNumber == 1)
        {
            return firstTerm;
        }

        return ratio * GetTerm(firstTerm, ratio, termNumber - 1);
    }

    /// <summary>
    /// Рекурсивно вычисляет сумму первых n членов геометрической прогрессии.
    /// </summary>
    /// <param name="firstTerm">Первый член прогрессии.</param>
    /// <param name="ratio">Знаменатель прогрессии.</param>
    /// <param name="termCount">Количество членов.</param>
    /// <returns>Сумма первых n членов.</returns>
    static double GetSum(double firstTerm, double ratio, int termCount)
    {
        if (termCount == 1)
        {
            return firstTerm;
        }

        return GetSum(firstTerm, ratio, termCount - 1)
            + GetTerm(firstTerm, ratio, termCount);
    }

    static void Main()
    {
        Console.Write("Введите первый член прогрессии a1: ");
        double firstTerm = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите знаменатель прогрессии q: ");
        double ratio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите количество членов n: ");
        int termCount = Convert.ToInt32(Console.ReadLine());

        if (termCount < 1)
        {
            Console.WriteLine("Количество членов должно быть больше нуля.");
            return;
        }

        double lastTerm = GetTerm(firstTerm, ratio, termCount);
        double sum = GetSum(firstTerm, ratio, termCount);

        Console.WriteLine($"a{termCount} = {lastTerm}");
        Console.WriteLine($"Сумма первых {termCount} членов = {sum}");
    }
}