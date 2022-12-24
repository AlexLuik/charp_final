public class MultiplicationTable
{
    static void Main(string[] args)
    {
        var table = new int[10, 10];
        for (int i = 1; i < 10; ++i)
        {
            for (int j = 1; j < 10; ++j)
            {
                table[i, j] = i * j;
                Console.Write("{0, 3}", table[i, j]);
            }
            Console.WriteLine();
        }
    }
}
