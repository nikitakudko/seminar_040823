Console.WriteLine("Введите натуральное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1)
{
    Console.WriteLine("Некорректный ввод");
    return;
}
NaturalNumber(num);

void NaturalNumber(int number)
{
    if (number == 0) return;
    NaturalNumber(number-1);
    Console.Write($"{number} ");
}

