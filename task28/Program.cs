
int ProductNumbers(int num)
{
int prod = 1;
 for(int i = 1; i <= num; i++)
 {
        checked
        {
            prod = prod * i;    
        }
        
 }
 return prod;
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)  
        {
            Console.WriteLine("Введено некоректное число");
        } 
        else
        {
            int productNumbers = ProductNumbers(number);
            Console.WriteLine ($"{number} -> {productNumbers}");
        }


