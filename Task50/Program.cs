// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

Console.Write("Введите номер строки: ");
int x = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите номер столбца: ");
int y = Convert.ToInt32(Console.ReadLine()) - 1;

if (x < 0 || y < 0)
{
    Console.WriteLine("Введено отрицательное число/числа");
}
else
{
    int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
    PrintMatrix(array2D);
    Console.WriteLine();
    FindElement(x, y, array2D);
}

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


void FindElement(int m, int n, int[,] matrix)
{
    if (m < matrix.GetLength(0) && n < matrix.GetLength(1))
        Console.WriteLine(matrix[m, n]);
    else
        Console.WriteLine("Такого элемента в массиве нет");
}

