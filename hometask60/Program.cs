// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

int[,,] GetRandomMatrix(int x, int y, int z)
{
    int[,,] matr = new int[x, y, z];
    int number = 9;
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                matr[i, j, k] = number + 1;
                number++;
            }

        }
    }
    return matr;
}

// метод для печати (вывода в консоль) двумерного массива
void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < 2; j++)
        {
            Console.WriteLine();
            for (int k = 0; k < 2; k++)
            {
                Console.Write($"{matr[i, j, k]} [{i}, {j}, {k}]"); ;
            }

        }

    }
}

int[,,] matrix = GetRandomMatrix(2, 2, 2);

PrintMatrix(matrix);