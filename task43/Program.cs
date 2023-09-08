/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

y1-b1 = k1*x1
x1 =(y1-b1)/k1*/

double Perisechenie(int k1, int b1, int k2, int b2)
{
    double x = -100;
    double y = 0;
    if(k1*x+b1 == k2*x + b2) 
    {
        y = k1*x+b1;
        Console.WriteLine($"{x}; {y}");
    }
    else x = x + 0.1;
    return x;
}

Console.WriteLine("Введите значение k1");
int a1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение b1");
int c1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k2");
int a2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение b2");
int c2 = Convert.ToInt32(Console.ReadLine());

Perisechenie(a1, c1, a2, c2);
