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
*/


int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
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

int[,] MultiOfTwoMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] matrixOfMulti = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
    //if(matrixOne.GetLength(1) == matrixTwo.GetLength(0))
    {
        for (int i = 0; i < matrixOne.GetLength(0); i++)  
        {
            for (int j = 0; j < matrixOne.GetLength(1); j++)
            {   
                for(int k = 0; k < matrixOne.GetLength(1); k++)
                
                    matrixOfMulti[i,j] =  matrixOfMulti[i, j] + matrixOne[i, k] * matrixTwo[k, j];
                
            }
        }
    }
    // else 
    // {
    //     //Console.WriteLine("Multiplication is impossible!");
    // }
    return matrixOfMulti;
}

    Console.Write("Input a number of rows for matrix 1: ");
    int rows1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns for matrix 1: ");
    int columns1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value for matrix 1: ");
    int minValue1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible valuefor matrix 1: ");
    int maxValue1 = Convert.ToInt32(Console.ReadLine());
    int[,] matrix1 = CreateRandom2dArray(rows1, columns1, minValue1, maxValue1);

    Console.Write("Input a number of rows for matrix 2: ");
    int rows2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns for matrix 2: ");
    int columns2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value for matrix 2: ");
    int minValue2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value for matrix 2: ");
    int maxValue2 = Convert.ToInt32(Console.ReadLine());
    int[,] matrix2 = CreateRandom2dArray(rows2, columns2, minValue2, maxValue2);

    Console.WriteLine("Your first matrix:");
    Show2dArray(matrix1);
    Console.WriteLine();
    Console.WriteLine("Your second matrix:");
    Show2dArray(matrix2);
    Console.WriteLine();
    
    if(matrix1.GetLength(1) == matrix2.GetLength(0))
    {   
        Console.WriteLine("Multiplication of matrices:");
        int[,] newMatrix = MultiOfTwoMatrix(matrix1, matrix2);
        Show2dArray(newMatrix);
    }
    else Console.WriteLine("Multiplication is impossible!");