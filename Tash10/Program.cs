Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int digit = Digit(number);
Console.WriteLine($"вторая цифра числа-> {digit}");

int Digit(int num)
{
    int firstdigit = number / 10;
    int seconddigit = firstdigit % 10;
    int result = seconddigit;
    return result;
}