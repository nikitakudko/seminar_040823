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

bool DigitExist(int[] arr, int n)
{
    for(int i = 0; i < arr.Length; i++ )
    {
        if(arr[i] == n) return true;
    }
    return false;
}

int[] array = CreateArrayRndInt(8, -8, 8);
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

bool answer = DigitExist(array, number);
Console.Write($"Присутствует ли число {number} в массиве ");
PrintArray(array);
Console.Write(answer? " ДА" : " НЕТ");

