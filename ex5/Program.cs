
class ex5
{
    static void Main()
    {
        int year, month, day;

        Console.Write("년도를 입력하세요 (2000~2100): ");
        year = int.Parse(Console.ReadLine());

        Console.Write("월을 입력하세요 (1~12): ");
        month = int.Parse(Console.ReadLine());

        Console.Write("일을 입력하세요 (1~31): ");
        day = int.Parse(Console.ReadLine());

       
        if (year < 2000 || year > 2100)
        {
            Console.WriteLine("년도는 2000~2100 사이여야 합니다.");
            return;
        }
        if (month < 1 || month > 12)
        {
            Console.WriteLine("월은 1~12 사이여야 합니다.");
            return;
        }
        if (day < 1 || day > 31)
        {
            Console.WriteLine("일은 1~31 사이여야 합니다.");
            return;
        }

        if (month == 1 || month == 2)
        {
            month += 12;  
            year--;       
        }

        int m = month;
        int q = day;
        int k = year % 100;
        int j = year / 100;

        int h = (q + (13 * (m + 1) / 5) + k + (k / 4) + (j / 4) - 2 * j) % 7;

        if (h < 0)
        {
            h += 7;
        }

        switch (h)
        {
            case 0:
                Console.WriteLine($"{year + (month > 12 ? 0 : 1)}년 {month % 12}월 {day}일은 토요일입니다.");
                break;
            case 1:
                Console.WriteLine($"{year + (month > 12 ? 0 : 1)}년 {month % 12}월 {day}일은 일요일입니다.");
                break;
            case 2:
                Console.WriteLine($"{year + (month > 12 ? 0 : 1)}년 {month % 12}월 {day}일은 월요일입니다.");
                break;
            case 3:
                Console.WriteLine($"{year + (month > 12 ? 0 : 1)}년 {month % 12}월 {day}일은 화요일입니다.");
                break;
            case 4:
                Console.WriteLine($"{year + (month > 12 ? 0 : 1)}년 {month % 12}월 {day}일은 수요일입니다.");
                break;
            case 5:
                Console.WriteLine($"{year + (month > 12 ? 0 : 1)}년 {month % 12}월 {day}일은 목요일입니다.");
                break;
            case 6:
                Console.WriteLine($"{year + (month > 12 ? 0 : 1)}년 {month % 12}월 {day}일은 금요일입니다.");
                break;
        }

        Console.ReadLine();
    }
}
