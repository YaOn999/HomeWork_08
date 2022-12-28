// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillArray(int columns, int rows)
{
    int[,] array = new int[columns, rows];
    int k = 0, l = 1, n = 1, m = 1,
        j = 0;
    int maxI = columns * rows;
    for (int i = 0; i < maxI + 1; i++)
    {
        array[l, k] = j;
        if (k < columns - n && l < m) k++;
            else if (k == columns - n && l < rows - m) l++;
            else if (l == rows - m && k > n - 1) k--;
            else if (k == n - 1 && l > m - 1)
            {
                l--;
                if(l == m)
                {
                    n++;
                    m++;
                }
            }
            j++;
            }
    return array;
}

void PrintArray(int[,] array, int columns, int rows)
{
    Console.WriteLine();
    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            Console.Write("{0:D2} ", array[i, j]);
        }
        Console.WriteLine();
    }
}

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int rows = EnterData("Введите количество строк и столбцов для первой и второй матрицы: ");
int columns = rows;

PrintArray(FillArray(columns, rows), columns, rows);