// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

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

int[,] matrixFirst = GetRandomMatrix(3, 4);
PrintMatrix(matrixFirst);
Console.WriteLine();
int[,] matrixSecond = GetRandomMatrix(3, 4);
PrintMatrix(matrixSecond);
Console.WriteLine();
if (matrixFirst.GetLength(0) != matrixSecond.GetLength(0) || matrixFirst.GetLength(1) != matrixSecond.GetLength(1))
{
    Console.WriteLine("Невозможно найти произведение");
}
int[,] matrixProduct = GetRandomMatrix(matrixFirst.GetLength(0), matrixFirst.GetLength(1));
for (int i = 0; i < matrixProduct.GetLength(0); i++)
{
    for (int j = 0; j < matrixProduct.GetLength(1); j++)
    {
        matrixProduct[i, j] = matrixFirst[i, j] * matrixSecond[i, j];
    }
}
PrintMatrix(matrixProduct);
Console.WriteLine();