//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (ValidDigit(number))
{
    Console.WriteLine(ThirdDigit(number));
}

int ThirdDigit(int num)
{
    while(number > 999)
    {
        number = number / 10;
    }
    return number % 10;
}

bool ValidDigit(int number)
{
    if(number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
} 

