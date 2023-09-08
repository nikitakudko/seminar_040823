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
    for (int i = 0; i < arr.Length;  i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] PairMultArray(int[] arr)
{
    int size = arr.Length / 2 + arr.Length % 2;
    int[] newArr = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length-1-i];
    }
    if (arr.Length % 2 == 1) newArr[size-1] = arr[arr.Length / 2]; 
    return newArr;
}

int[] array = CreateArrayRndInt(5, 1, 9);
PrintArray(array);
Console.WriteLine();

int [] pairArray = PairMultArray(array);
PrintArray(pairArray);