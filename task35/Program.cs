int [] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int [size];
    Random random = new Random();
    for(int i = 0; i < arr.Length; i++ )
    {
        arr[i]= random.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++ )
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int CountNumbers(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++ )
    {
        if(arr[i] >= 10 && arr[i] <= 99) count++;
    }
    return count;
}

int[] array = CreateArrayRndInt(123, 0, 1000);
PrintArray(array);
Console.WriteLine();
int countNum = CountNumbers(array);
Console.WriteLine($"Количество двузначных элементов массива {countNum}");