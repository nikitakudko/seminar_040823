﻿int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine(" |");
    }

}

int[,] MatrixOddIndexElemPow(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
            matrix[i, j] *= matrix[i, j] ;
        }
    }
    return matrix;
}
int[,] mtr = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(mtr);
Console.WriteLine();
int[,] mtrPow = MatrixOddIndexElemPow(mtr);
PrintMatrix(mtrPow);