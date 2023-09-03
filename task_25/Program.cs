
int a = Convert.ToInt32(Console.ReadLine()); // Вводим число
int b = Convert.ToInt32(Console.ReadLine()); // Вводим значение степени
    
int CountPow(int a, int b)
{
    int pow = a;
    for (int i = 1; i < b; i++)
    {
        pow *= a;
    }

    return pow;
}

Console.WriteLine(CountPow(a, b));   
Console.WriteLine(Math.Pow(a, b)); // Проверка для себя