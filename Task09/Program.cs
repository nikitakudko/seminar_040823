int number = new Random().Next(10, 100 );
Console.WriteLine($"случайное числов в диапазоне 10-99 -> {number}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа-> {maxDigit}");

int MaxDigit(int num)
{
    int firstdigit = number / 10;
    int seconddigit = number % 10;
    int result = firstdigit > seconddigit ? firstdigit : seconddigit;
    return result;
}