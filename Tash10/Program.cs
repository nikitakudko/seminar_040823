//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

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