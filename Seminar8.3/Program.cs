// Из двумерного массива целых чисел нужно удалить строку и столбец на пересечении которых расположен наименьший элемент.

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество строк: ");
int columns = int.Parse(Console.ReadLine()!);
 
int[,] array = GetArray(rows, columns, 1, 99);
PrintArray(array);
Console.WriteLine();

//int minelement=ElementMin(array);
//Console.WriteLine(minelement);

int minelement = ElementMin(array);
Console.WriteLine(minelement);
Console.WriteLine();
int maxelement=ElementMax(array);
Console.WriteLine(maxelement);
Console.WriteLine();

int[,] array2 = NewArray(array, minelement);
PrintArray(array2);

//Ищем наименьший элемент
int ElementMin (int[,] array)
{
    int[,] resu = new int[array.GetLength(0), array.GetLength(1)];
    int iMin=0;
    int jMin=0;
    int elem = array[0,0];

    {
        for(int i=0; i<array.GetLength(0); i++)
        {
            for(int j=0; j<array.GetLength(1); j++)
            {
                if(array[i,j]<=elem)
                {
                  iMin=i;
                  jMin=j;
                  elem = array[i,j];
                }
            }
        }
    }
    return elem;
}

//Ищем наибольший элемент
int ElementMax (int[,] array)
{
    int[,] resul = new int[array.GetLength(0), array.GetLength(1)];
    int maxnumber = resul[0,0];
    {
        for(int i=0; i<array.GetLength(0); i++)
        {
            for(int j=0; j<array.GetLength(1); j++)
            {
                if(maxnumber<=array[i,j])
                {
                    maxnumber=array[i,j];
                }
            }
        }
    }
    return maxnumber;
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

//Удаляем строки
int[,] NewArray (int[,] array, int minValue)
{
    int[,] res = new int[array.GetLength(0), array.GetLength(1)];
    int i1=0;
    int j1=0;
    minValue = res[i1,j1];

    for(int i=0; i<array.GetLength(0); i++)
    {
     for(int j=0; j<array.GetLength(1); j++)
    {
      if((i1==i)&&(j1==j))
      {
       res[i,j]=array[i,j];
      }
    }    
}
    return res;
}