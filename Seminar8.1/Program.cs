// Задать двум. массив. Написать программу, которая поменяет первую и последнюю строку массива.

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество строк: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 1, 99);
PrintArray(array);

Console.WriteLine();

int[,] array2 = RowOne(array, rows, columns);
PrintArray(array2);

Console.WriteLine();

int[,] array3 = RowPast(array, rows, columns);
PrintArray(array3);

Console.WriteLine();

int[,] arrayresult = NewArray(array, array2, array3, rows, columns);  
PrintArray(arrayresult);

//Ищем первую строку
int[,] RowOne (int[,] array, int row, int column)
{
    int[,] result = new int[row, column];
    {
        for(int i=0; i==0; i++)
        {
            for(int j=0; j<column; j++)
            {
                result[i,j]=array[i,j];
            }
        }
    }
    return result;
}

//Ищем последнюю строку
int[,] RowPast (int[,] array, int ro, int colum)
{
    int[,] resul = new int[ro, colum];
    {
        int i = ro-1;
        {
            for(int j=0; j<array.GetLength(1); j++)
            {
                resul[i,j]=array[i,j];
            }
        }
    }
    return resul;
}

//Меняем местами строки
int[,] NewArray (int[,] arra, int[,] arra2, int[,] arra3, int r, int c)
{
    {
        for(int i = 0; i<arra.GetLength(0); i++)
        {
            for(int j = 0; j<arra.GetLength(1); j++)
            {
                if(arra2[i,j]==0)
                {
                  arra2[i,j]=arra[i,j];
                  arra2[r-1,j]=arra2[0,j];
                  
                }
                if(arra3[i,j]==0)
                {
                    arra3[i,j]=arra2[i,j];
                }
                else
                {
                    arra2[0,j]=arra3[i,j];
                }
            }
        }
    }
    return arra2; 
}



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