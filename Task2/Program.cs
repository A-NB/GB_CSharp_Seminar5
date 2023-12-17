// Знакомство с языками программирования (семинары)
// Урок 5. Двумерные Массивы

// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

Random rnd = new Random();
int row = rnd.Next(2, 11);
int col = rnd.Next(2, 11);
int[,] matrix = FillArray(row, col);
Console.Clear();
System.Console.WriteLine("Массив matrix:");
System.Console.WriteLine("--------------------");
PrintArray(matrix);
int temp = 0;

for (int j = 0; j < matrix.GetLength(1); j++)
{
    temp = matrix[0, j];
    matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
    matrix[matrix.GetLength(0) - 1, j] = temp;
}

System.Console.WriteLine();
System.Console.WriteLine($"Массив matrix, в котором\nпервая и последняя ({matrix.GetLength(0)}) строка\nпоменялись местами:");
System.Console.WriteLine("--------------------");
PrintArray(matrix);
