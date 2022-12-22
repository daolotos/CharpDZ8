Console.WriteLine("Введите размер квадратной матрицы:");

int M = ReadInt("M = ");

int[,] matrix1 = new int[M,M];
int[,] matrix2 = new int[M,M];

RandomizeArray(matrix1);
RandomizeArray(matrix2);

Console.WriteLine("Матрица 1:");
PrintArray(matrix1);
Console.WriteLine("Матрица 2:");
PrintArray(matrix2);

var matrix3 = MultiplyMatix(matrix1, matrix2);

Console.WriteLine($"Результат перемножения матриц:");
PrintArray(matrix3);

int[,] MultiplyMatix(int[,] m1, int[,] m2)
{
    int[,] r = new int[M, M];
    for (int x = 0; x < M; x++)
        for (int y = 0; y < M; y++)
        {
            int sum = 0;
            for (int i = 0; i < M; i++)
                sum += m1[i,y] * m2[x,i];
            r[x, y] = sum;
        }
    return r;
}

void RandomizeArray(int[,] array)
{
    Random rnd = new Random();
    for (int x = 0; x < M; x++)
        for (int y = 0; y < M; y++)
            array[x, y] = rnd.Next(1, 4);
}

int ReadInt(string prompt)
{
    Console.Write(prompt);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

void PrintArray(int[,] array)
{
    for (int y = 0; y < M; y++)
    {
        for (int x = 0; x < M; x++)
            Console.Write($"{array[x, y],5} ");
        Console.WriteLine("");
    }
}