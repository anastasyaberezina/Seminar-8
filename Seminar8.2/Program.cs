// Задать двум массив. Написать программу, которая заменяет строки на столбцы.

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество строк: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 1, 99);
PrintArray(array);

Console.WriteLine();

int[,] array2 = ColumnRow(array);
PrintArray(array2);

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

int[,] ColumnRow (int[,] array)
{
 int[,] resul = new int[array.GetLength(0), array.GetLength(1)];
 for(int i=0; i<array.GetLength(0); i++)
  {
    for(int j=0; j<array.GetLength(1); j++)
    {
     resul[j,i]=array[i,j];
    }
  }
    return resul;
}