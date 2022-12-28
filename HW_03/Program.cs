// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// 2*3 + 4*3 = 18 (0, 0) (i, j)
// 3*3 + 2*3 = 15 (1, 0) (i+1, j)
// 2*4 + 4*3 = 20 (0, 1) (i, j+1)
// 3*4 + 2*3 = 18 (1, 1) (i+1, j+1)

// i столбец, j строка
// (i, j)*(i, j) + (i, j+1)*(i+1, j) = (i, j)
// (i+1, j)*(i, j) + (i+1, j+1)*(i+1, j) = (i+1, j)

// (i, j)*(i, j+1) + (i, j+1)*(i+1, j+1) = (i, j+1)
// (i+1, j)*(i, j+1) + (i+1, j+1)*(i+1, j+1) = (i+1, j+1) 

void PrintArray(int[,] array)
{
    Console.WriteLine();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ProductTwoMatrices(int[,] firstMatrix, int[,] secondMatrix, int columns, int rows)
{
    int[,] NewArray = new int[columns, rows];

    for (int i = 0; i < columns; i++)
    {
        for(int j = 0; j < rows; j++)
        {
            for (int k = 0; k < rows; k++)
                {
                    NewArray[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                }
        }
    }
    return NewArray;
}

int[,] FillArray(int columns, int rows, int begin, int end)
{
    int[,] array = new int[columns, rows];
    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            array[i, j] = new Random().Next(begin, end);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int rows = EnterData("Введите количество строк и столбцов для первой и второй матрицы: ");
int columns = rows;
int[,] firstMatrix = FillArray(rows, columns, 0, 10);
Console.WriteLine();
int[,] secondMatrix = FillArray(rows, columns, 0, 10);

PrintArray(ProductTwoMatrices(firstMatrix, secondMatrix, columns, rows));
