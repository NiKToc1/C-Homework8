void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 101);
    }
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}\t");
        
        Console.WriteLine();
    }
}

int StringSum (int[,] matrix, int i)
{
    int sum = matrix[i, 0];
    for (int j = 0; j < matrix.GetLength(1); j++)
        sum += matrix[i, j];
    return sum;
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);

int MinSum = 0;
int sum = StringSum(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
    int TempSum = StringSum(matrix, i);
    if (sum > TempSum)
    {
        sum = TempSum;
        MinSum = i;
    }
}

Console.WriteLine($"{MinSum + 1} строка");