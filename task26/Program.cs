int CountDigit(int num)
{
    int count = 0;
    if (num == 0) return 1;
     
    while (num != 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());
int countdigit = CountDigit(number);

Console.WriteLine($"Количество цифр в числе -> {countdigit}");
