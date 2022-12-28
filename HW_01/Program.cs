// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки 
// двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void PrintArray(int[,] arr, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] SortArray(int[,] arr, int columns, int rows)
{
    int temp;
    for (int i = 0; i < columns; i++)
    {
        for (int k = 0; k < rows; k++)
        {
            for(int j = 0; j < rows - 1; j++)
            {
                if (arr[i, j] < arr[i, j+1])
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[i, j+1];
                    arr[i, j+1] = temp;
                }
            }
        }
    }
    return arr;
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

int columns = EnterData("Введите количество столбцов: ");
int rows = EnterData("Введите количество строк: ");
int[,] matrix = FillArray(columns, rows, 0, 10);
Console.WriteLine();

PrintArray(SortArray(matrix, columns, rows), columns, rows);