bool TreugolExisit(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b) return true;
    else return false;
}

Console.WriteLine("Введите длинну стороны АВ");
int aB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длинну стороны АC");
int aC = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длинну стороны ВC");
int bC = Convert.ToInt32(Console.ReadLine());

bool result = TreugolExisit(aB, aC, bC);

Console.WriteLine($"Существует ли треугольник с данными сторонами -> {result}");

