// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] GetRandomMatrix(int rows, int columns, int leftRange = 0, int rightRange = 10)
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


int[,] matrix = GetRandomMatrix(3, 4);
PrintMatrix(matrix);
int minSum = 0;
int sumCurrent = 0;
int minSumIndex = 0;
for (int j = 0; j < matrix.GetLength(1); j++)
{
    minSum = minSum + matrix[0, j];
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sumCurrent = sumCurrent + matrix[i, j];
    }
    if (sumCurrent <= minSum)
    {
        minSum = sumCurrent;
        minSumIndex = i;
    }
    sumCurrent = 0;
}
Console.WriteLine();
Console.WriteLine(minSumIndex);

