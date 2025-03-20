class ex3
{
    static void Main()
    {
        int num = 0;
        bool sosu = true;
        Console.Write("양의 정수를 입력하세요");
        num = int.Parse(Console.ReadLine());
        if (num <= 2)
        {
            Console.WriteLine($"{num}은 소수가 아닙니다. ");
            return;
        }
        else
        {
            if (num % 2 == 0)
            {
                sosu = false;
                return;
            }
            else
            {
                for (int i = 3; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        sosu = false;
                        break;
                    }
                    else
                    {
                        sosu = true;
                    }
                }
            }
        }
        if (sosu)
        {
            Console.WriteLine($"{num}은 소수입니다.");
        }
        else
        {
            Console.WriteLine($"{num}은 소수가 아닙니다.");
        }
        Console.ReadLine();
    }
}