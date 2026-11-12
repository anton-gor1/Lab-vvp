using System;

class Program
{
    /// <summary>
    /// Вычисляет оптимальный вес и выводит рекомендацию пользователю
    /// </summary>
    static void Main()
    {
        Console.Write("Введите рост в сантиметрах: ");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите вес в килограммах: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Оптимальный вес вычисляется по формуле "рост - 100"
        double optimalWeight = height - 100;

        Console.WriteLine($"Оптимальный вес: {optimalWeight} кг");

        if (weight < optimalWeight)
        {
            Console.WriteLine("Рекомендуется поправиться.");
        }
        else if (weight > optimalWeight)
        {
            Console.WriteLine("Рекомендуется похудеть.");
        }
        else
        {
            Console.WriteLine("Ваш вес соответствует оптимальному.");
        }
    }
}