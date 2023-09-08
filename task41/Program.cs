int[] CreateArray(int m)
{
    int[] arr = new int[m];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите число");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int PositiveCount(int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
      if(arr[i] > 0) count++;  
    }
    return count;
}
Console.WriteLine("Введите количество количество чисел");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
PrintArray(array);
Console.Write($" -> {PositiveCount(array)}");