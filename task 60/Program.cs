int InputValues(string values)
{
    Console.Write(values);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void InputMatrix(int[,,] matrixXYZ)
{
    int[] temp = new int[matrixXYZ.GetLength(0) * matrixXYZ.GetLength(1) * matrixXYZ.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for(int j = 0; j < i; j++)
            {
                while (temp[i] < temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < matrixXYZ.GetLength(0); x++)
    {
        for (int y = 0; y < matrixXYZ.GetLength(1); y++)
        {
            for (int z = 0; z < matrixXYZ.GetLength(2); z++)
            {
                matrixXYZ[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

void PrintMatrix(int[,,] matrixXYZ)
{
    for (int i = 0; i < matrixXYZ.GetLength(0); i++)
    {
        for (int j = 0; j < matrixXYZ.GetLength(1); j++)
        {
            Console.Write($"X({i}) Y({j}) ");
            for (int k = 0; k < matrixXYZ.GetLength(2); k++)
                Console.Write($"Z({k}) = {matrixXYZ[i, j, k]};");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.Clear();

int x = InputValues("Введите X: ");
int y = InputValues("Введите Y: ");
int z = InputValues("Введите Z: ");
Console.WriteLine($"");

int[,,] matrixXYZ = new int[x, y, z];
InputMatrix(matrixXYZ);
PrintMatrix(matrixXYZ);
