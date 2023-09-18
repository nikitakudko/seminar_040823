/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int Promt(string message)
{
    Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int AkkermanFunction(int n, int m) 
{
    while(n != 0 )
    {
        if( m == 0 ) m = 1;
        else m = AkkermanFunction(n, m-1);
        n--;
    }
    return m + 1 ;
}

int num1 = Promt("Введите число M");
int num2 = Promt("Введите число N");

if (num1 < 1 || num2 < 1)
{
    Console.WriteLine("Некорректный ввод");
    return;
}
Console.WriteLine($"{AkkermanFunction(num1, num2)}");
