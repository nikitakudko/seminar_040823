void FillArr(int[] mass)
{
int i = 0;
var random = new Random();
while(i < mass.Length)
{
mass[i] = random.Next(10, 100);
i++;
}
}

void PrintArr(int[] mass)
{
int i = 0;
while(i < mass.Length)
{
Console.Write($"{mass[i]} ");
i++;
}
}

int[] array = new int[8];
FillArr(array);
PrintArr(array);