int SumDigit(int num)
{
    int sum = 0;
    if (num == 0) return 0;
    int i = num % 10;
    for (; num != 0; i = num % 10)
    {
        num = num / 10;
        sum = sum + i;
    }
    return sum;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {number} -> {SumDigit(number)}");