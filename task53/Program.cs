// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

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

int[,] matrix = GetRandomMatrix(3, 4);
PrintMatrix(matrix);
Console.WriteLine();
int temp;
for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp = matrix[0,j];
            matrix[0,j] = matrix[matrix.GetLength(0) - 1, j];
            matrix[matrix.GetLength(0) - 1, j] = temp;
        }
PrintMatrix(matrix);