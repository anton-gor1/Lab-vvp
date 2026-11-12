class Program
{
    /// <summary>
    /// Запрашивает данные цилиндра и вычисляет его высоту
    /// </summary>
    static void Main()
    {
        Console.Write("V = ");
        double volume = Convert.ToDouble(Console.ReadLine());

        Console.Write("S = ");
        double area = Convert.ToDouble(Console.ReadLine());

        // Высота цилиндра равна объему, деленному на площадь основания
        double height = volume / area;

        Console.WriteLine($"Ответ: {height} м");
    }
}