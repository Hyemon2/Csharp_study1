class ex4
{
    static void Main()
    {
        int height = 0;
        int type = 1;
        Console.Write("삼각형의 높이를 입력하세요 : ");
        height = int.Parse(Console.ReadLine());
        Console.Write("삼각형의 종류를 선택하세요(1-3) : ");
        type = int.Parse(Console.ReadLine());
        switch (type)
        {
            case 1:
                for (int i = 1; i <= height; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
                break;
            case 2:
                for (int i = 1; i <= height; i++)
                {
                    for (int j = height; j > i; j--)
                    {
                        if (i < j)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
                break;
            case 3:
                for (int i = 1; i <= height; i++)
                {
                    for (int j = height; j > i; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i * 2 - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
                break;
        }
    }
}