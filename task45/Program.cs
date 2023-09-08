int[] CopyArray(int[] array)
{
    int[] coppyArr = new int[array.Length];
    for (int i = 0; i < coppyArr.Length; i++)
    {
        coppyArr[i] = array[i];

    }
    return coppyArr;
}

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(min, max + 1);
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
int[] array = CreateArrayRndInt(5, 1, 9);
PrintArray(array);
Console.WriteLine();
int[] array1 = CopyArray(array);
array1[0] = 100;
PrintArray(array1);
Console.WriteLine();
PrintArray(array);