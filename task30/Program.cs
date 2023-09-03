void FillArray(int[] mass)
{
    Random random = new Random();
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = random.Next(2);
    }
}
void PrintArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write(mass[i] + " ");
    }
}
int[] array = new int[8];
FillArray(array);
PrintArray(array);


