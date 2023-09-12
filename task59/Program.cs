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

int[] FindIndexMinElem(int[,] matrix)
{
    int rowMin = 0;
    int columnMin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[rowMin, columnMin])
            {
                rowMin = i;
                columnMin = j;
            }
        }
    }
    return new int[] { rowMin, columnMin };
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[,] DeleteRowAndColumnsOfMinElem(int[,] matrix, int rowMin, int columnMin)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0, n = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (m == rowMin) m += 1;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (n == columnMin) n += 1;
            newMatrix[i, j] = matrix[m, n];
            n++;
        }
        m++;
        n = 0;
    }
    return newMatrix;
}

int[,] mtr = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(mtr);
Console.WriteLine();
int[] arr = FindIndexMinElem(mtr);

int[,] newMtr = DeleteRowAndColumnsOfMinElem(mtr, arr[0], arr[1]);
PrintMatrix(newMtr);