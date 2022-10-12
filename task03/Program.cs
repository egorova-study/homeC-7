// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
int [ , ] array2D = CreateMatrixRndInt(matrixSize_i, matrixSize_j, -10, 10);
PrintMatrix(array2D);


double denum = matrixSize_i;
for (int j = 0; j < matrixSize_j; j++) 
{
    double columnSumm = 0;
    for (int i = 0; i < matrixSize_i; i++)
    {
        columnSumm += array2D[i,j];

    }
    double columnMean = Math.Round(columnSumm/denum, 3);
    Console.WriteLine ($"{columnMean}");

}