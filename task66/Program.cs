/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


int SumFromNum1ToNum2(int num1, int num2)
{
    if(num1 == num2) return num2;
    else if (num1<num2) return num1 + SumFromNum1ToNum2(num1 + 1, num2);  
    else return num1 + SumFromNum1ToNum2(num1 - 1, num2); 
}

int Promt(string message)
{
    Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int m = Promt("Введите число M");
int n = Promt("Введите число N");

if (m < 1 || n < 1)
{
    Console.WriteLine("Некорректный ввод");
    return;
}

Console.WriteLine($"{SumFromNum1ToNum2(m, n)}");
