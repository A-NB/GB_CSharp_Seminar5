// Знакомство с языками программирования (семинары)
// Урок 5. Двумерные Массивы

// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] FillArray (int rows, int columns)
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

void PrintArray (int[,] matrix)
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
int[,] matrix = FillArray(row, col);
Console.Clear();
System.Console.WriteLine("Массив matrix:");
PrintArray(matrix);
System.Console.Write("Введите через пробел позицию элемента массива (№строки №столбца): ");
string indexes = System.Console.ReadLine();
int rowElement = Convert.ToInt32(indexes.Split()[0]);
int colElement = Convert.ToInt32(indexes.Split()[1]);

if (rowElement >= 0 && rowElement < row &&
    colElement >= 0 && colElement < col)
System.Console.WriteLine($"matrix[{rowElement}, {colElement}] = {matrix[rowElement, colElement]}");
else
System.Console.WriteLine($"Введённые индексы указывают за пределы массива!");
