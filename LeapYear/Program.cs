using System;
public class LeapYear
{
    public static void Main(string[] args)
    {
        int k;
        Console.Write("Введите год: ");
        k = int.Parse(Console.ReadLine());
        Console.Write($"Год {k} {(leapYear(k) ? "високосный" : "не високосный")}");

    }

    public static bool leapYear(int k)
    {
        if (k % 4 == 0 && (k % 100 != 0 || k % 400 == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
