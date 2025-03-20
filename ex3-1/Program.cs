class ex32
{
    static void Main()
    {
        int num = 0;
        Console.WriteLine("소수 판별 프로그램 \n소수가 입력 될떄까지 계속 반복합니다.");
        while (true)
        {
            Console.Write("숫자를 입력하세요 : ");
            num = int.Parse(Console.ReadLine());
            bool sosu = true;
            if (num == 2)
            {
                sosu = true;
            }
            else if (num % 2 == 0)
            {
                sosu = false;
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
            if (sosu)
            {
                Console.WriteLine($"{num}은 소수입니다.");
                Console.WriteLine("프로그램을 종료합니다.");
                break;
            }
            else
            {
                Console.WriteLine($"{num}은 소수가 아닙니다.");
            }
        }
        Console.ReadLine();
    }
}