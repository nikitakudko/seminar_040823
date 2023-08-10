int number = new Random().Next(10, 100 );
Console.WriteLine($"случайное числов в диапазоне 10-99 -> {number}");

int firstdigit = number / 10;
int seconddigit = number % 10;

int maxdigit = firstdigit;
if(seconddigit>maxdigit) seconddigit = maxdigit;

Console.WriteLine($"Наибольшая цифра случайного числа из диапазона - {maxdigit}");

    