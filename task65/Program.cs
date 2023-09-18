Console.WriteLine("Введите натуральное число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 1 || n < 1)
{
    Console.WriteLine("Некорректный ввод");
    return;
}

void RangeNaturalNumber(int num1, int num2)
{
    if(num1 < num2)
    {
        Console.Write($"{num1} ");
        RangeNaturalNumber(num1 + 1, num2);
    }
    else if(num1 > num2)
    {
        Console.Write($"{num1} ");
        RangeNaturalNumber(num1 - 1, num2);
    }
    else Console.Write($"{num1}");
}

RangeNaturalNumber(m, n);
