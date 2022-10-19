//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] array = GetArray(4, 4, 1, 30);
PrintArray(array);

Console.WriteLine();

int[,] array2 = GetArray(4, 4, 1, 30);
PrintArray(array2);

Console.WriteLine();

int[,] arrayRes = MatrixQuer(array, array2);
PrintArray(arrayRes);

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

int[,] MatrixQuer(int[,] array, int[,] array2)
{
    int[,] n = new int[array.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(1); k++)
            {
                n[i, k] += array[i, j] * array[j, k];
            }
        }
    }
    return n;
}
