/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
double[,] numbers = new double[rows, columns];

FillMatrixRandomDoubleNumbers(numbers, 0, 10);
WriteMatrix(numbers);



void FillMatrixRandomDoubleNumbers(double[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Random sluchainoe_chislo = new Random();
            double floating_point = sluchainoe_chislo.NextDouble() + sluchainoe_chislo.Next(min, max);
            floating_point = Math.Round(floating_point, 2);
            array[i, j] = floating_point;
        }
    }
}

void WriteMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
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

