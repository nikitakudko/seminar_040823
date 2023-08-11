Console.WriteLine("Введите число");
int firnum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int secnum = Convert.ToInt32(Console.ReadLine());
if(firnum % secnum == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        int result = firnum % secnum;
        Console.WriteLine($"{result}");
    }