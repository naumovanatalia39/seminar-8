// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, // на пересечении которых расположен наименьший элемент массива.

// метод для создания двумерного массива
int[,] GetRandomMatrix(int rows, int columns, int leftRange = 0, int rightRange = 9)
{
    int[,] matr = new int[rows, columns];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return matr;
}

// метод для печати (вывода в консоль) двумерного массива
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }

    }
}

int[,] matrix = GetRandomMatrix(5, 4);
PrintMatrix(matrix);
Console.WriteLine();
int min = matrix[0, 0];
int minRow = 0;
int minColumn = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] < min)
        {
            min = matrix[i, j];
            minColumn = j;
            minRow = i;
        }
    }
}

Console.WriteLine();
Console.WriteLine(minRow);
Console.WriteLine(minColumn);
int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
int offsetRow = 0;
int offsetColumn = 0;

for (int i = 0; i < newMatrix.GetLength(0); i++)
{
    if (i == minRow) offsetRow = 1;
    for (int j = 0; j < newMatrix.GetLength(1); j++)
    {
        if (j == minColumn) offsetColumn = 1;
        newMatrix[i, j] = matrix[i + offsetRow, j + offsetColumn];
    }
    offsetColumn = 0;
}
Console.WriteLine();
PrintMatrix(newMatrix);