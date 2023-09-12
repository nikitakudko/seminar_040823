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

void ReplaceColumnsToRow(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1) ;
    int temp;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < i; j++)
        {
            temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

bool IsMatrixSquare(int[,] matrix)
{
    return (matrix.GetLength(0)== matrix.GetLength(1));
}

int[,] mtr = CreateMatrixRndInt(4, 5, 0, 10);
PrintMatrix(mtr);
Console.WriteLine();
if (!IsMatrixSquare(mtr))
{
    Console.WriteLine("Невозможно заменить строки на столбцы");
    return;
}
ReplaceColumnsToRow(mtr);
PrintMatrix(mtr);