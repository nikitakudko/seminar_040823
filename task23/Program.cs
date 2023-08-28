bool Palindrom(int number)
{
    if(number < 10000 && number >= 100000)
    {
        Console.WriteLine("Число не пятизначное");
        return false;
    }
    {
    int firstdigit = number / 10000;
    int seconddigit = (number / 1000) % 10;
    int fourthdigit =  (number / 10) % 10;
    int fifthdigit = number % 10;
    bool x = fifthdigit == firstdigit && seconddigit == fourthdigit;
    }
    return x;
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

Palindrom(num);