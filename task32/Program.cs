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

int [] InverseArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) arr[i] = arr[i] * -1;
        else arr[i] = arr[i] * -1;
    }
    return arr;
}

int[] array = CreateArrayRndInt(8, -8, 8);
PrintArray(array);
Console.WriteLine();
InverseArray(array);
PrintArray(array);