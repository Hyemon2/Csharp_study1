class ex1
{
    static void Main()
    {
        Console.Write("1부터 12 사이의 월을 입력하세요 : ");
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("1월은 31일까지 있습니다");
                Console.ReadLine();
                break;
            case 2:
                Console.WriteLine("2월은 28일까지 있습니다.");
                Console.ReadLine();
                break;
            case 3:
                Console.WriteLine("3월은 31일까지 있습니다.");
                Console.ReadLine();
                break;
            case 4:
                Console.WriteLine("4월은 30일까지 있습니다.");
                Console.ReadLine();
                break;
            case 5:
                Console.WriteLine("5월은 31일까지 있습니다.");
                Console.ReadLine();
                break;
            case 6:
                Console.WriteLine("6월은 30일까지 있습니다.");
                Console.ReadLine();
                break;
            case 7:
                Console.WriteLine("7월은 31일까지 있습니다.");
                Console.ReadLine();
                break;
            case 8:
                Console.WriteLine("8월은 31일까지 있습니다.");
                Console.ReadLine();
                break;
            case 9:
                Console.WriteLine("9월은 30일까지 있습니다.");
                Console.ReadLine();
                break;
            case 10:
                Console.WriteLine("10월은 31일까지 있습니다.");
                Console.ReadLine();
                break;
            case 11:
                Console.WriteLine("11월은 30일까지 있습니다.");
                Console.ReadLine();
                break;
            case 12:
                Console.WriteLine("12월은 31일까지 있습니다.");
                Console.ReadLine();
                break;
            default:
                Console.WriteLine("1부터 12 사이의 숫자를 입력하세요");
                break;
        }
    }
}
