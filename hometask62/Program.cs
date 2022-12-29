// Задача 62. Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

int[,] matrSpiral = new int[4, 4];
int number = 1;
for (int j = 0; j < 4; j++)
{
    matrSpiral[0, j] = number;
    number++;
}
for (int i = 1; i < 4; i++)
{
    matrSpiral[i,3] = number;
    number++;
}
for (int j = 2; j >= 0; j--)
{
    matrSpiral[3, j] = number;
    number++;
}
for (int i = 2; i >= 1; i--)
{
    matrSpiral[i,0] = number;
    number++;
}
for (int j = 1; j < 3; j++)
{
    matrSpiral[1, j] = number;
    number++;
}
for (int j = 2; j >= 1; j--)
{
    matrSpiral[2, j] = number;
    number++;
}

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

PrintMatrix(matrSpiral);