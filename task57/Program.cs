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

int[] MatrixToArray(int[,] matrix)
{
    int r = 0;
    int[] array = new int[matrix.Length];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[r] = matrix[i, j];
            r++;
        }
    }
    return array;
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

void FrequencyDictionary(int[] array)
{
    int count = 1;
    int num = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] == num)
        {
            count++;
        }
        else
        {
            Console.WriteLine($" число {num} встречается {count} раз");
            count = 1;
            num = array[i];
        }
    }
    Console.WriteLine($" число {num} встречается {count} раз");
}
int[,] mtr = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(mtr);
Console.WriteLine();
int[] arr = MatrixToArray(mtr);
Array.Sort(arr);
PrintArray(arr);
Console.WriteLine();
FrequencyDictionary(arr);