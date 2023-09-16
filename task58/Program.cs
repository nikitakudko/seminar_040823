/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

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
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("");
    }
}

int [,] ProductMatrix(int[,] matrix1, int[,] matrix2)
{   
    int [,] prodMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < prodMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < prodMatrix.GetLength(1); j++)
        {
            prodMatrix[i,j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                prodMatrix[i,j] += matrix1[i,k] * matrix2[k,j];
            }
        }
    }
    return prodMatrix;
}
bool PosobilitiProduct(int[,] matrix1, int[,] matrix2)
{
    return (matrix1.GetLength(1) == matrix2.GetLength(0));
}

int[,] mtr1 = CreateMatrixRndInt(2, 3, 0, 4);
int[,] mtr2 = CreateMatrixRndInt(3, 2, 0, 4);

if(!PosobilitiProduct(mtr1, mtr2))
{
    Console.WriteLine("Произведение невозможно");
    return;
}

PrintMatrix(mtr1);
Console.WriteLine();
PrintMatrix(mtr2);
int[,] prodMtr = ProductMatrix(mtr1, mtr2);
Console.WriteLine();
PrintMatrix(prodMtr);
