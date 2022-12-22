
int M = 3;
int N = 4;

int[,] array = new int[M, N];

RandomizeArray(array);

PrintArray(array);

Console.WriteLine("Средние значения столбцов:");

for (int y = 0; y < N; y++)
{
    float mean = FindMeanForRow(array, y);
    Console.Write($"{mean,5:#.##} ");
}

float FindMeanForRow(int[,] array, int y)
{
    float sum = 0;
    for (int x = 0; x < M; x++)
        sum += array[x, y];
    return sum / M;
}

void RandomizeArray(int[,] array)
{
    Random rnd = new Random();
    for (int x = 0; x < M; x++)
        for (int y = 0; y < N; y++)
            array[x, y] = rnd.Next(0, 20);
}

void FindNumberAndPrintResult(int[,] array, int num)
{
    bool isFound = false;
    for (int x = 0; x < M; x++)
        for (int y = 0; y < N; y++)
        {
            if (array[x, y] == num)
            {
                if (isFound == false)
                    Console.Write("Это число есть на позициях: ");
                isFound = true;
                Console.Write($"[{x},{y}] ");
            }
        }
    if (!isFound)
        Console.WriteLine("Такого числа нет в это массиве");
}


int ReadInt(string prompt)
{
    Console.Write(prompt);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

void PrintArray(int[,] array)
{
    for (int x = 0; x < M; x++)
    {
        for (int y = 0; y < N; y++)
            Console.Write($"{array[x, y],5} ");
        Console.WriteLine("");
    }
}