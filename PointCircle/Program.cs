using System;
public class PointCircle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите координату x");
        double x = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите координату y");
        double y = int.Parse(Console.ReadLine());

        Console.WriteLine($"Точка ({x},{y}) {(InCircle(x, y) ? "находится в границах окружности" : "находиться вне гарниц окружности")}");
    }


    public static bool InCircle(double x, double y)
    {
        double radius = 2;
        double pointX = 0;
        double pointY = -1;
        double d = Math.Sqrt(Math.Pow(x - pointX, 2) + Math.Pow(y - pointY, 2));
        if (d <= radius)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
