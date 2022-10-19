/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.*/

int[,,] array = GetArray(4, 4, 4, 10, 99);
PrintArray(array);

Console.WriteLine();

int[,,] arrayRes = Matrix3D(array);
PrintArray(arrayRes);

int[,,] GetArray (int m, int n, int c, int minValue, int maxValue)
{
    int[,,] result = new int[m,n,c];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            for(int k=0; k<c; k++)
            {
            result[i,j,k]=new Random().Next(minValue, maxValue+1);
            }
        }
    }
    return result;
}

void PrintArray (int[,,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            for(int k = 0; k<array.GetLength(2); k++)
        {
            Console.Write($"{array[i,j,k]} ");
        }
        Console.WriteLine();
    }
}}

int[,,] Matrix3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = array[i,j,k]; Console.Write($"{i} {j} {k}");
                
            }
        }
    }
   return array;
}


