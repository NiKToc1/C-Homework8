void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 31);
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

void SortMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int l = 0; l < matrix.GetLength(1)-1;l++)
            {
                if (matrix[i, l] < matrix[i, l + 1])
                {
                    int temp = matrix[i, l + 1];
                    matrix[i, l + 1] = matrix [i, l];
                    matrix[i, l] = temp;
                }
            }
        }
    }
}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальная матрица: ");
PrintMatrix(matrix);
Console.WriteLine("Конечная матрица: ");
SortMatrix(matrix);
PrintMatrix(matrix);
