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

void MatrixProduct(int[,] firstMatrix, int[,] secondMatrix, int[,] productMatrix)
{
    for(int i = 0; i < productMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < productMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int l = 0; l < firstMatrix.GetLength(1); l++)
                sum += firstMatrix[i, l] * secondMatrix[l, j];
            productMatrix[i, j] = sum;
        }
    }
}

Console.Clear();
Console.Write("Введите размеры матриц: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] firstMatrix = new int[size[0], size[1]];
int[,] secondMatrix = new int[size[0], size[1]];
int[,] productMatrix = new int[size[0], size[1]];

InputMatrix(firstMatrix);
Console.WriteLine("Первая матрица: ");
PrintMatrix(firstMatrix);
InputMatrix(secondMatrix);
Console.WriteLine("Вторая матрица: ");
PrintMatrix(secondMatrix);

MatrixProduct(firstMatrix, secondMatrix, productMatrix);
Console.WriteLine("Произведение первой и второй матриц: ");
PrintMatrix(productMatrix);