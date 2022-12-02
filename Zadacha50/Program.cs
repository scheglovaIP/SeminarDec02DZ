/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет */

int rows = ReadInt("Введите количество строк (от 1 до 9 вкл): ");
int columns = ReadInt("Введите количество столбцов (от 1 до 9 вкл): ");
int[,] numbers = new int[rows, columns];
FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);
int position = ReadInt("Введите позицию искомого элемента: ");
int rowsPosition = position/10;
int columnsPosition = position%10;
if(rowsPosition>=numbers.GetLength(0) || columnsPosition>=numbers.GetLength(1))
Console.WriteLine($"Позиции [{rowsPosition}, {columnsPosition}] в заданном массиве не существует!");
else
Console.WriteLine($"В элемент с индексом [{rowsPosition}, {columnsPosition}] записано число {numbers[rowsPosition, columnsPosition]}.");



void FillMatrixRandomNumbers(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void WriteMatrix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

