// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[ , ] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           matrix[i, j] = rnd.Next(min, max + 1); 
        }
    }

    return matrix;
}

void PrintMatrix (int [ , ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4} ");
            else Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("|");
    }
}
int matrixSize_i = 3;
int matrixSize_j = 4;
int [ , ] array2D = CreateMatrixRndInt(matrixSize_i, matrixSize_j, -100, 100);
PrintMatrix(array2D);
Console.WriteLine ("введите номер строки");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите номер столбца");
int j = Convert.ToInt32(Console.ReadLine());

if (i>=matrixSize_i || j>=matrixSize_j) Console.Write ("такого элемента в массиве нет");
else Console.WriteLine ($"{array2D [i, j]}");