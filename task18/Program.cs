
string? CoordinateRange(int q)
{
    if(q == 1) return  "x > 0; y > 0";
    if(q == 2) return  "x < 0; y > 0";
    if(q == 3) return  "x < 0; y < 0";
    if(q == 4) return  "x > 0; y < 0";
    return null;
}

Console.WriteLine("Введите номер четверти:");
int quarter = Convert.ToInt32(Console.ReadLine());
string result = CoordinateRange(quarter);

Console.Write(result != null ? $"Диапазон:  {result}" : "Некорректный ввод");
