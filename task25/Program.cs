/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int Pow( int numA, int numB)
{
    int prod = 1;
    for(int i = 1; i<= numB; i++)
    {
        prod = prod * numA;
    }
    return prod;
}
Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a}, {b} -> {Pow(a, b)}");