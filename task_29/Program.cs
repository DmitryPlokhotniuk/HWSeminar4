int[] array = new int[8];

void RandomArr (int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(0, 255);
        Console.Write(array[i] + ", ");
    }
}
RandomArr(array);