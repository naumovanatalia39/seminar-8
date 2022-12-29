// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

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
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        int minPosition = j;
        for (int t = j + 1; t < matrix.GetLength(1); j++)
        {
            if (matrix[i, t] < matrix[i, minPosition])
            {
                minPosition = t;
            }
        }
        int temp = matrix[i, j];
        matrix[i, j] = matrix[i, minPosition];
        matrix[i, minPosition] = temp;
       
    }

}
PrintMatrix(matrix);