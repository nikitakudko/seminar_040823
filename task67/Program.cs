Console.WriteLine("Введите  число");
int num = Convert.ToInt32(Console.ReadLine());

int SumDigitOfNumber(int n)
{
if (n  == 0) return 0;
return n % 10  + SumDigitOfNumber(n/10);
}
Console.WriteLine(SumDigitOfNumber(num)); 