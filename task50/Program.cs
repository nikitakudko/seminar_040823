void PrintArray (int [,] matrix)
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
  
 int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
    int[,] matrix = new int[n, m];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            matrix[0, 0] = 1;
            matrix[i, j] = matrix[i, j-1] + k;
        }  
    }
    return matrix;
    }
/* 
int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
    {  
      // Введите свое решение ниже


    }

void PrintCheckIfError (int[] results, int X, int Y)
    {
      // Введите свое решение ниже


    }
*/
int[,] matrix = CreateIncreasingMatrix(3, 4, 2);
PrintArray(matrix);
