int number = new Random().Next(100, 1000 );
Console.WriteLine($"случайное числов в диапазоне 100-1000 -> {number}");

int digit = Digit(number);
Console.WriteLine($"новое число-> {digit}");

int Digit(int num)
{
    int firstdigit = num / 100;
    int thirddigit = num % 10;
    int result = firstdigit * 10 + thirddigit;
    return result;
}