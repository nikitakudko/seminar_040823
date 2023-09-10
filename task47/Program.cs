double[, ] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
{
    double[,] matrix = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
        matrix[i, j] = rnd.NextDouble() * (maxLimitRandom-minLimitRandom) + minLimitRandom;
       }  
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            Console.Write($" {matrix[i, j],5 :F2} "); 
        }
        Console.WriteLine();
    }
}

double[,] mtr = CreateRandomMatrix(3, 4, -10, 10);
PrintMatrix(mtr);