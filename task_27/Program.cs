int number = Convert.ToInt32(Console.ReadLine());

int Sum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    return sum;
}

Console.WriteLine(Sum(number));