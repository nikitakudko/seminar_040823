/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

void NaturalNumber(int number)
{
    if (number == 0) return;
    Console.Write($"{number} ");
    NaturalNumber(number-1);
}

int Promt(string message)
{
    Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int Validation(int number)
{
    if (number < 1) number = Promt("Некоректрное число. Введите натуральное число: ");
    return number;
}

int num = Promt("Введите число");
Validation(num);
Console.Write($"{num} -> ");

NaturalNumber(num);
