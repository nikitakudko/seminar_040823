int number = new Random().Next(10, 100 );
Console.WriteLine($"случайное числов в диапазоне 10-99 -> {number}");

int firstdigit = number / 10;
int seconddigit = number % 10;

int result = firstdigit > seconddigit ? firstdigit : seconddigit;

Console.WriteLine($"Наибольшая цифра случайного числа - {result}");

    