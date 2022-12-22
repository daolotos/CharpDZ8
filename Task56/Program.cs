Console.WriteLine("Введите размеры массива:");

int M = ReadInt("M = ");
int N = ReadInt("N = ");

int[,] array = new int[M, N];

RandomizeArray(array);
PrintArray(array);

int index = GetLineWithMinimumSumm(array);

Console.WriteLine($"Индекс строки с минимальной суммой: {index}");

int GetLineWithMinimumSumm(int[,] array)
{
    int index = 0;
    int minSumm = Int32.MaxValue;
    for (int y = 0; y < N; y++)
    {
        var summ = GetLineSumm(array, y);
        if (summ < minSumm)
        {
            minSumm = summ;
            index = y;
        }
    }
    return index;
}

int GetLineSumm(int[,] array, int y)
{
    int summ = 0;
    for (int x = 0; x < M; x++)
    {
        summ += array[x, y];
    }
    return summ;
}

void RandomizeArray(int[,] array)
{
    Random rnd = new Random();
    for (int x = 0; x < M; x++)
        for (int y = 0; y < N; y++)
            array[x, y] = rnd.Next(0, 20);
}

int ReadInt(string prompt)
{
    Console.Write(prompt);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

void PrintArray(int[,] array)
{
    for (int y = 0; y < N; y++)
    {
        for (int x = 0; x < M; x++)
            Console.Write($"{array[x, y],5} ");
        Console.WriteLine("");
    }
}