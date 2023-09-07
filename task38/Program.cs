/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

double[] CreateArrayRndInt(int size)
{
    double[] arr = new double[size];
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.NextDouble() * 100;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]:F2}, ");
        else Console.Write($"{arr[i]:F2}");
    }
    Console.Write("]");
}

double DiferenseMinMax(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];
        if (min > arr[i]) min = arr[i];
    }
    return max - min;
}

Console.WriteLine("Введите размер массива");
int sizeArray = Convert.ToInt32(Console.ReadLine());

double[] array = CreateArrayRndInt(sizeArray);
PrintArray(array);
Console.WriteLine();
double result = DiferenseMinMax(array);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива {result:F2}");