Console.Clear();
// Задача 2: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.


int[,] CreateIntMatrix(int rowes, int columns, int minInt, int maxInt) // Метод принимает значения 
// количества строк, количества столбцов, наименьшее целочисленное значение элемета,  
// наибольшее целочисленное значение элемета
// и возвращает двумерный массив заполненый случайными целыми числами.
{
    Random rand = new Random();
    int[,] matrix = new int[rowes, columns];
    for (int i = 0; i < rowes; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(minInt, maxInt);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix) // Метод принимает двумерный массив и выводит его на экран.
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
int[,] ChangeMatrixRowes(int[,] matrix) //Метод принимает двумерный массив и
//возвращает двумерный массив в котором поменяны местами первая и последняя строки. 
{
    for (int i = 0, j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[i, j];
        matrix[i, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = temp;
    }
    return matrix;
}
int[,] matr = CreateIntMatrix(5, 5, -100, 100);
Console.Write("The matrix before the change:\n");
PrintMatrix(matr);
Console.Write("The matrix after the change:\n");
PrintMatrix(
    ChangeMatrixRowes(matr));