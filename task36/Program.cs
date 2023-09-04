/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/


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

int SumOddNumbers(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++ )
    {
        if(i % 2 !=0) sum += arr[i];
    }
    return sum;
}
Console.WriteLine("Введите размер массива");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента массива");
int minArrayNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента массива");
int maxArrayNumber = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(sizeArray, minArrayNumber, maxArrayNumber);
PrintArray(array);
Console.WriteLine();
int result = SumOddNumbers(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях {result}");