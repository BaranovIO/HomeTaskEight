//задача 54. Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    
        for(int j = 0; j < columns; j++)
        
            array[i,j] = new Random().Next(minValue, maxValue +1);
        
    
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");  

        Console.WriteLine();
    }

    Console.WriteLine();
}


int[,] BubbleSortArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0) ; i++)
    
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        
            for(int k = 0; k < array.GetLength(1) - 1; k++)
                
                if(array[i, k + 1] > array[i, k])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i , k] = temp;
                }            
    
    return array;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
BubbleSortArray(myArray);
Console.WriteLine();
Show2dArray(myArray);
*/

//Задача 56. Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    
        for(int j = 0; j < columns; j++)
        
            array[i,j] = new Random().Next(minValue, maxValue +1);
        
    
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");  

        Console.WriteLine();
    }

    Console.WriteLine();
}

int[] SumOfRows(int[,] array)
{   
    int[] arrayOfRowSum = new int[array.GetLength(0)];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sumOfRow = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        
            sumOfRow = sumOfRow + array[i,j];
                
        arrayOfRowSum[i] = sumOfRow;
    }
    return arrayOfRowSum;
}

void RowOfMinimumSum(int[] array)
{
    int iMin = 0;
    int minValue = array[0];

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < minValue)
        iMin = i;
    }
    
    Console.Write($"The row with the minimum sum of elements is {iMin + 1}");
}



int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
RowOfMinimumSum(SumOfRows(myArray));
*/

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    
        for(int j = 0; j < columns; j++)
        
            array[i,j] = new Random().Next(minValue, maxValue +1);
        
    
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");  

        Console.WriteLine();
    }

    Console.WriteLine();
}

void RowOfMinimumSum(int[,] array)
{   
    int iMin = 0, minSumOfRow = 0;
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sumOfRow = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        
            sumOfRow = sumOfRow + array[i,j];
        if(sumOfRow < minSumOfRow)
        {   minSumOfRow = sumOfRow;
            iMin = i;
        }
    }
    Console.WriteLine($"The row with minimum sum of elements is {iMin + 1}");
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
RowOfMinimumSum(myArray);
