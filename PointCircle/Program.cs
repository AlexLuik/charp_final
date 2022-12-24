using System;
public class PointCircle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите координату x");
        double x = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите координату y");
        double y = int.Parse(Console.ReadLine());

        double d = Math.Sqrt(Math.Pow(x - 0, 2) + Math.Pow(y + 1, 2));
        if (d <= 2)
        {
            Console.WriteLine("Точка находится в границах окружности.");
        }
        else
        { 
        Console.WriteLine("Точка находится вне границ окружности.");
        }
        Console.ReadKey();
    }
}
