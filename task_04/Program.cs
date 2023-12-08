Console.Clear();
// Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент 
// массива. Под удалением понимается создание нового двумерного массива без строки и столбца.


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
            matrix[i, j] = rand.Next(minInt, maxInt + 1);
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

int[] SearchMinIndexesValueOfMatrix(int[,] matrix)  // Метод принимает двумерный массив и
// возвращает одномерный массив размерностью [2] с индексами наименьшего значения двумерного массива.
{
    int[] array = new int[2]; //он уже заполнен нулями
    int minValue = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minValue) 
            {
                array[0] = i; array[1] = j;
            }
        }
    }
    return array;
}



int[,] matr = CreateIntMatrix(2, 3, 0, 10);
PrintMatrix(matr);
Console.WriteLine($"[{string.Join("\t", SearchMinIndexesValueOfMatrix(matr))}]");
