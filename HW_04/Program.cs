// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы 
// каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// сначала создаем одномерный уникальный массив,
// затем заполняем трехмерный полученными значениями
void FillArray(int page, int columns, int rows, int begin, int end)
{
    int size = page * columns * rows;
    int[] tempArray = new int[size];

    int[,,] array = new int[page, columns, rows];
    int temp = 0;
    
    for (int i = 0; i < size; i++)
    {
        bool isUnique;
        do
        {
            tempArray[i] = new Random().Next(begin, end);
            isUnique = true;
            for (int j = 0; j < i; ++j)
                if (tempArray[i] == tempArray[j])
                    {
                        isUnique = false;
                        break;
                    }
        } while (!isUnique);
    }

    for (int i = 0; i < page; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < rows; k++)
            {
                array[i, j, k] = tempArray[temp];
                temp++;
                Console.WriteLine($"{array[i, j, k]}({i},{j},{k})");
            }
            Console.WriteLine();
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

int page = EnterData("Введите количество страниц: ");
int columns = EnterData("Введите количество столбцов: ");
int rows = EnterData("Введите количество строк: ");

if (page * columns * rows > 90) Console.WriteLine("слишком большой массив, уникальные двухзначные значения не возможны");
else FillArray(page, columns, rows, 10, 100);
