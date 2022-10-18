/* Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.*/

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество строк: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 1, 50);
PrintArray(array);

Console.WriteLine();

int[,] array2 = NewArray(array, rows, columns);
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

int[,] NewArray (int[,] array, int row, int column)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)]; //Присвоили размерность массива новому массиву
    for(int i = 0; i<array.GetLength(0); i++) //Индекс строки
    {  
        for(int j = 0; j<array.GetLength(1); j++) //Индекс столбца
        {
            for(int m = 0; m<array.GetLength(1)-1; m++)
            {
                if(array[i,m]<array[i,m+1])
                {
                    int x = array[i,m+1];
                    array[i,m+1]=array[i,m];
                    array[i,m]=x;
                }
            }
        }
    }
    return array;
}
   
    
        






