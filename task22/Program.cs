
void TableSquare(int n)
{
    int i = 1;
    while( i<= n)
    {
        Console.WriteLine($"{i, 3} -> {i * i, 5}");
        i++;
    }
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

TableSquare(number);


