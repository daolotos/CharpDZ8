Console.WriteLine("Введите размеры массива:");

int M = ReadInt("M = ");
int N = ReadInt("N = ");

int[,] array = new int[M, N];

Spiral(array, 0, 0, M - 1, N - 1, 0);

Console.WriteLine("Спиральный массив:");
PrintArray(array);

void Spiral(int[,] array, int xMin, int yMin, int xMax, int yMax, int startIndex)
{
    int index = startIndex;
    FillLine(xMin, yMin, 1, 0);
    if (yMin == yMax)
        return;
    FillLine(xMax, yMin + 1, 0, 1);
    FillLine(xMax - 1, yMax, -1, 0);
    yMin++;
    if (xMin == xMax)
        return;
    FillLine(xMin, yMax - 1, 0, -1);

    void FillLine(int x, int y, int dx, int dy)
    {
        while (x >= xMin && y >= yMin && x <= xMax && y <= yMax)
        {
            array[x, y] = index++;
            x += dx;
            y += dy;
        }
    }

    if (xMin <= xMax && yMin <= yMax)
        Spiral(array, xMin + 1, yMin, xMax - 1, yMax - 1, index);
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