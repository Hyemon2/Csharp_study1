class ex2
{
    static void Main()
    {
        for (int i = 2; i < 10; i++)
        {
            Console.WriteLine($"---{i}단----");
            for (int j = 1; j < 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
        }
        Console.ReadLine();
    }
}