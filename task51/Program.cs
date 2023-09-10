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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine(" |");
    }

}

int SumMainDiogonaleElem(int[,] matrix)
{
    int sum = 0;
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int size = rows < columns? rows: columns;
    for (int i = 0; i < size; i++)
    {
      sum += matrix[i, i];  
    }
    return sum;
}
int[,] mtr = CreateMatrixRndInt(15, 10, 1, 10);
PrintMatrix(mtr);
Console.WriteLine();
int result = SumMainDiogonaleElem(mtr);

Console.WriteLine($"Сумма элементов находящихся на главной диагонали -> {result}");