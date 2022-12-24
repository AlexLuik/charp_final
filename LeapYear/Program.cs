using System;
public class LeapYear
{
    public static void Main(string[] args)
    {
        int k;
        Console.Write("Введите год: ");
        k = int.Parse(Console.ReadLine());
        if (k % 4 == 0 && (k % 100 != 0 || k % 400 == 0))
        {
            Console.Write("Год високосный");
        }
        else
        {
            Console.Write("Год не високосный");
        }
    }
}
