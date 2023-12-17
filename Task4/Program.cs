// Знакомство с языками программирования (семинары)
// Урок 5. Двумерные Массивы

// Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. Под удалением понимается создание нового двумерного массива без строки и столбца

int[,] GetRandom2DArray()
{
    Random rnd = new Random();
    int row = rnd.Next(2, 11);
    int col = rnd.Next(2, 11);
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rnd.Next(rnd.Next(0, 50), rnd.Next(51, 100));
        }
    }
    return array;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] matrix = GetRandom2DArray();

Console.Clear();
System.Console.WriteLine("Массив matrix:");
System.Console.WriteLine();
PrintArray(matrix);

int[,] resMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
int minElement = matrix[0, 0], minRow = 0, minCol = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] < minElement)
        {
            minElement = matrix[i, j];
            minRow = i;
            minCol = j;
        }
    }
}

System.Console.WriteLine();
System.Console.WriteLine($"Минимальный элемент матрицы равен {minElement}, его адрес - [ {minRow}, {minCol} ]");
System.Console.WriteLine();

for (int i = 0, ii = 0; i < matrix.GetLength(0); i++)
{
    if (i == minRow) continue;
    for (int j = 0, jj = 0; j < matrix.GetLength(1); j++)
    {
        if (j == minCol) continue;
        resMatrix[ii, jj] = matrix[i, j];
        jj++;
    }
    ii++;
}

/* int newRow = 0;
int newCol = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i != minRow && j != minCol)
        {
            resMatrix[newRow, newCol] = matrix[i, j];
            newRow++;
            newCol++;
        }

    }

} */

System.Console.WriteLine($"Результирующий массив:");
System.Console.WriteLine();
PrintArray(resMatrix);
