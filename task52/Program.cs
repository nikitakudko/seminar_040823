void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}" + "\t");
        }
        Console.WriteLine("");
    }
}

int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] matrix = new int[n, m];
    int temp = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = temp;
            temp += k;
        }

    }
    return matrix;
}
void PrintListAvr(double[] list)
{
    Console.WriteLine("The averages in columns are: ");
    foreach (double average in list)
    {
        Console.Write(average.ToString("F2") + "\t");
    }
    Console.WriteLine("");
}

double [] FindAverageInColumns (int [,] matrix)
    { 
      double [] avg = new double[matrix.GetLength(1)];
      double sumColumns = 0;
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        sumColumns = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sumColumns += matrix[i,j]; 
        }
        avg[j] = sumColumns / matrix.GetLength(0);
      }
      return avg;
    }

/*double[] FindAverageInColumns(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    double[] arr = new double[columns];
    double sumColumns = 0;
    for (int i = 0; i < columns; i++)
    {
        sumColumns = 0;
        for (int j = 0; j < rows; j++)
        {
            sumColumns += matrix[j, i];
        }
        arr[i] = sumColumns;
    }
    return arr;
}*/
int[,] result = CreateIncreasingMatrix(3, 4, 2);
PrintArray(result);
PrintListAvr(FindAverageInColumns(result));