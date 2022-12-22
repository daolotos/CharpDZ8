Console.WriteLine("Введите размеры массива:");

int M = ReadInt("M = ");
int N = ReadInt("N = ");

int[,] array = new int[M, N];

RandomizeArray(array);

Console.WriteLine("Исходный массив:");
PrintArray(array);

SortArray(array);

Console.WriteLine("Массив с отсортированными строками:");
PrintArray(array);

void SortArray(int[,] array)
{
    for (int y = 0; y < N; y++)
        SortLine(array, y);
}

void SortLine(int[,] array, int y)
{
    for (int x = 0; x < M - 1; x++)
        for (int x2 = x + 1; x2 < M; x2++)
        {
            if (array[x, y] >= array[x2, y])
                continue;
            int temp = array[x, y];
            array[x, y] = array[x2, y];
            array[x2, y] = temp;
        }
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