// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

Console.Write("Введите количество строк Матрицы 1: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов Матрицы 1 и количество строк Матрицы 2: ");
int t = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nМАТРИЦА 1: ");
int[,] firstMatrix = new int[m, t];

CreateArray(firstMatrix);
PrintArray(firstMatrix);

Console.Write("\nВведите количество столбцов Матрицы 2: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nМАТРИЦА 2: ");
int[,] secondMatrix = new int[t, n];

CreateArray(secondMatrix);
PrintArray(secondMatrix);

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] matrixProduct = new int[m, n];

MultiplyMatrices(firstMatrix, secondMatrix, matrixProduct);
Console.WriteLine($"\nПроизведение Матрицы 1 на Матрицу 2:");
PrintArray(matrixProduct);

void MultiplyMatrices(int[,] firstMatrix, int[,] secondMatrix, int[,] matrixProduct)
{
    for (int i = 0; i < matrixProduct.GetLength(0); i++)
    {
        for (int j = 0; j < matrixProduct.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            matrixProduct[i, j] = sum;
        }
    }
}