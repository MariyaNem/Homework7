// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");
    }
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

double[] SumEachColomn(int[,] matrix)
{
    double[] sumArr = new double[matrix.GetLength(1)];
    int column = 0;
    for (int i = 0; i < matrix.GetLength(0) + 1; i++)
    {
        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            sumArr[i] += matrix[x, column];
        }
        column++;
    }
    return sumArr;
}

double[] AverageEachColomn(double[] sumArr, int[,] matrix)
{
    for (int i = 0; i < sumArr.Length; i++)
    {
        sumArr[i] = Math.Round(sumArr[i] / matrix.GetLength(0), 1);
    }
    return sumArr;

}


int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
double[] sumEachColomn = SumEachColomn(array2D);
double[] averageEachColomn = AverageEachColomn(sumEachColomn, array2D);
PrintArray(averageEachColomn);