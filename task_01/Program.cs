Console.Clear();

// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateIntMatrix(int rowes, int columns, int minInt, int maxInt) // Метод принимает значения 
// количества строк, количества столбцов, наименьшее целочисленное значение элемета,  
// наибольшее целочисленное значение элемета и возвращает двумерный массив заполненый случайными числами.
{
    Random random = new Random();
    int[,] matrix = new int[rowes, columns];
    for (int i = 0; i < rowes; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(minInt, maxInt + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)// Метод принимает двумерный массив и выводит его на экран.
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] matr = CreateIntMatrix(5, 5, -100, 100);
PrintMatrix(matr);
Console.WriteLine("enter the line number");
int i = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the column number");
int j = int.Parse(Console.ReadLine()!);
if (i >= matr.GetLength(0)
|| i < 0
|| j >= matr.GetLength(1)
|| j < 0)
{
    Console.WriteLine($"Элемента матрицы с индексом [{i},{j}] нет");
}
else Console.WriteLine($"Элемент матрицы с индексом [{i},{j}] = {matr[i, j]}");