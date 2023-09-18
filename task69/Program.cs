
int Promt(string message)
{
    Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int Validation(int num)
{
    if (num < 1) num = Promt("Некоректрное число. Введите целночисленное число: ");
    return num;
}

int APowB (int num1, int num2 )
{
    if(num2 == 0) return 1;
    return num1 *  APowB(num1, num2 - 1);
}

int number1 = Promt("Введите первое число: ");
int number2 = Promt("Введите второе число: ");
number2 = Validation(number2);
Console.WriteLine(APowB(number1, number2)); 
