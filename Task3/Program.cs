// Знакомство с языками программирования (семинары)
// Урок 5. Двумерные Массивы

// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] FillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
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

Random rnd = new Random();
int row = rnd.Next(2, 11);
int col = rnd.Next(2, 11);
if (row == col) col += 1;  // Массив должен быть прямоугольныи, т. е. row != col
int[,] matrix = FillArray(row, col);
Console.Clear();
System.Console.WriteLine("Массив matrix:");
PrintArray(matrix);

int sum = 0, minSum = 0, resRow = 0;

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        sum += matrix[i, j];
    }
    if (i == 0) minSum = sum;
    if (sum < minSum)
    {
        minSum = sum;
        resRow = i;
    }
    sum = 0;
}

System.Console.Write($"В массиве сумма элементов строки с индексом {resRow} минимальна и равна {minSum}");
