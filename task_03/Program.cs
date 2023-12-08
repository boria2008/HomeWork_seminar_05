Console.Clear();
// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.


int[,] CreateIntMatrix(int rowes, int columns, int minInt, int maxInt)  // Метод принимает значения 
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

void PrintMatrix(int[,] matrix)  // Метод принимает двумерный массив и выводит его на экран.
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

int[] SumOfRowes(int[,] matrix) // Метод принимает двумерный массив 
// и возвращает одномерный массив  с  суммой элементов строк.
{
    int[] array = new int[matrix.GetLength(0)];
    for (int m = 0, i = 0; i < matrix.GetLength(0); m++, i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[m] = sum;
    }
    return array;
}

int SearchMinIndexValueOfArray(int[] array)  // Метод принимает на вход одномерный массив и
// возвращает индекс с наименьшим значением элемента.
{
    int indexMinValue = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[i - 1])
            indexMinValue = i;
    }
    return indexMinValue;
}

int[,] matr = CreateIntMatrix(3, 5, -10, 10);
Console.WriteLine("Исходная матрица :");
PrintMatrix(matr);
Console.WriteLine(
    $"Сумма элементов построчно:[{string.Join(
    "\t", SumOfRowes(matr))}]");
Console.WriteLine(
    $"Строка с наименьшей суммой элементов имеет индекс [{SearchMinIndexValueOfArray(
    SumOfRowes(matr))}]");