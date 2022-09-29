// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("\nМассив для сортировки:");
int row = new Random().Next(2, 10);
int columns = new Random().Next(2, 10);
int[,] array = new int[row, columns];

CreateArray(array);
PrintArray(array);

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 101);
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

Console.WriteLine("\nОтсортированный массив:");

SortArrayRow(array);
PrintArray(array);

void SortArrayRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int tmp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = tmp;
                }
            }
        }
    }
}