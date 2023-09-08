double NumberToBinarySystem(int num)
{
    double binary = 0;
    for (int i = 0; num > 0; i++)
    {
        double t = Math.Pow(10,i);
        binary = binary + num % 2 * t; 
        num = num / 2;
    }
    return binary;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumberToBinarySystem(number));



