class ex22
{
    static void Main()
    {
        for (int i = 2; i <= 9; i += 3)
        {
            for (int j = i; j < i + 3 && j <= 9; j++)
            {
                Console.Write($"--- {j}단 ---\t");
            }
            Console.WriteLine();
            for (int k = 1; k <= 9; k++)
            {
                for (int j = i; j < i + 3 && j <= 9; j++)
                {
                    Console.Write($"{j} x {k} = {j * k}\t");
                }
                Console.WriteLine();
            }
        }
        Console.ReadLine();
    }
}