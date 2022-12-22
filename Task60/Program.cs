Console.WriteLine("Введите размеры массива:");

int M = ReadInt("M = ");
int N = ReadInt("N = ");
int P = ReadInt("P = ");

int[,,] array = new int[M, N, P];

RandomizeArray(array);

Console.WriteLine("Трехмерный массив построчно:");
PrintArray(array);

void RandomizeArray(int[,,] array)
{
    Random rnd = new Random();
    for (int x = 0; x < M; x++)
        for (int y = 0; y < N; y++)
            for (int z = 0; z < P; z++)
                array[x, y, z] = rnd.Next(0, 20);
}

int ReadInt(string prompt)
{
    Console.Write(prompt);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

void PrintArray(int[,,] array)
{
    for (int y = 0; y < N; y++)
    {
        for (int x = 0; x < M; x++)
        {
            for (int z = 0; z < P; z++)
                Console.Write($"{array[x, y, z],4}({x},{y},{z}) ");
            Console.WriteLine("");
        }
    }
}