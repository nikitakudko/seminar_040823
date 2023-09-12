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
            Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("");
    }
}

void ReplaceFirstAndLastRow(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int temp;
    for (int i = 0; i < columns; i++)
    {
        temp = matrix[0,i];
        matrix[0,i] = matrix[rows-1, i];
        matrix[rows-1, i] = temp;
    }
}
int[,] mtr = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(mtr);
Console.WriteLine();
ReplaceFirstAndLastRow(mtr);
PrintMatrix(mtr);


