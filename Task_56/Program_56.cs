// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("\nМассив для поиска строки с наименьшей суммой элементов: ");

int row = new Random().Next(2, 5);
int columns = new Random().Next(2, 5);
int[,] array = new int[row, columns];

CreateArray(array);
PrintArray(array);

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
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

int index = 0;
int minSumma = SummarizeRowNumbers(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tmpSumma = SummarizeRowNumbers(array, i);
    if (minSumma > tmpSumma)
    {
        minSumma = tmpSumma;
        index = i;
    }
}

int SummarizeRowNumbers(int[,] array, int i)
{
    int summaRowNumbers = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        summaRowNumbers += array[i, j];
    }
    return summaRowNumbers;
}
Console.WriteLine($"\nНаименьшая сумма  элементов в строках : {minSumma}");
Console.WriteLine($"Строкa с наименьшей суммой  элементов : {index + 1}");