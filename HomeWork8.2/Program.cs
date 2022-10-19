/* Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.*/

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 1, 50);
PrintArray(array);

Console.WriteLine();

int rowmin = SumRow(array);
Console.WriteLine($"Наименьшая сумма элементов в {rowmin} строке.");

int[,] GetArray (int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j]=new Random().Next(minValue, maxValue+1);
        }
    }
    return result;
}

void PrintArray (int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int SumRow(int[,] array)
{
    int rowSumRes = 0; 
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int rowSum1 = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum1 += array[i, j];
        }
        if (i == 0)
        {
            rowSumRes = rowSum1;
        }
        else if (rowSum1 < rowSumRes)
        {
            rowSumRes = rowSum1;
            index = i;
        }
    }
    int rowSumRes2 = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        rowSumRes2 += array[index, j];
    }
    Console.Write($"В строке с минимальной суммой элементов сумма элементов составляет {rowSumRes2}.");
    Console.WriteLine();
    return index + 1;
}