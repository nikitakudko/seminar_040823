/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int[,] CreateSpiralMatrix(int n, int m)
{
    int[,] matrix = new int[n, m];
    int temp = 1;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = temp;
            temp += 1;
        }
    }
    for (int j = matrix.GetLength(1)-1; j > matrix.GetLength(1) ; j++)
    {
        for (int i = 1; i < matrix.GetLength(1); i++)
        {
            matrix[i, j] = temp;
            temp += 1;
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
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("");
    }
}

int[,] mtr = CreateSpiralMatrix(4,4);
PrintMatrix(mtr);