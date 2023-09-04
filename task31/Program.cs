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

int [] SumPositiveNegativeElements(int [] arr)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for(int i = 0; i < arr.Length; i++ )
    {
        if(arr[i] > 0) sumPositive += arr[i];
        else sumNegative += arr[i];
    }
    return new int[]{sumPositive, sumNegative};
}

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
Console.WriteLine();
int[] sumPositiveNegativeElements = SumPositiveNegativeElements(array);
Console.WriteLine($"Сумма положительных элементов = {sumPositiveNegativeElements[0]}");
Console.WriteLine($"Сумма отрицательных элементов = {sumPositiveNegativeElements[1]}");