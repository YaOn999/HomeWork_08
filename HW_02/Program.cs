// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 
// 1 строка

void MinIndexArray(int[] sumArray, int columns)
{
    int minNumber = sumArray[0];
    int indexMinNumber = 0;
    for (int i = 1; i < columns; i++)
    {
        if (sumArray[i] < minNumber) 
        {
            minNumber = sumArray[i];
            indexMinNumber = i;
        }
    }
    Console.WriteLine($"наименьшая сумма элементов в(во): {indexMinNumber + 1} строке");
}

int[] SumRowsArray(int[,] arr, int columns, int rows)
{
    int sum = 0;
    int[] sumArray = new int[columns];

    for (int i = 0; i < columns; i++)
    {
        for(int j = 0; j < rows; j++)
        {
            sum += arr[i, j];
        }
    Console.WriteLine(sum);
    sumArray[i] = sum;
    sum = 0;
    }
    return sumArray;
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

int rows = EnterData("Введите количество строк и столбцов: ");
int columns = rows;
int[,] matrix = FillArray(rows, columns, 0, 10);

int[] sumArray = SumRowsArray(matrix, columns, rows);
MinIndexArray(sumArray, columns);
