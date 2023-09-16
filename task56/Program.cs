/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("");
    }
}

bool IsMatrixRectangular(int[,] matrix)
{
    return (matrix.GetLength(0) != matrix.GetLength(1));
}

int[] ArraySumRowNumbers(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
            array[i] = sum;
        }
    }
    return array;
}

void PrintArray(int[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            if (i < array.Length - 1) Console.Write($"{array[i]}, ");
            else Console.Write($"{array[i]}");
        }
        Console.Write("]");
    }


void NumberRowMinSum(int[] array)
{
    int indexMinNum = 0;
   for (int i = 0; i < array.Length; i++)
   {
    if(array[i] < array[indexMinNum]) indexMinNum = i;
   } 
    Console.WriteLine($"номер строки с наименьшей суммой элементов: {indexMinNum + 1} строка");
}


int[,] mtr = CreateMatrixRndInt(4, 5, 0, 10);

if (!IsMatrixRectangular(mtr))
    {
        Console.WriteLine("Матрица не прямоугольная");
        return;
    }

PrintMatrix(mtr);
Console.WriteLine();
int[] arr = ArraySumRowNumbers(mtr);
NumberRowMinSum(arr);


