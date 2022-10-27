/* Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7 ,8 -7, 1 9 */

Messager("Ведите кол-во строк матрицы: ");
int m = EnteringDimensions();

Messager("Ведите кол-во столбцов матрицы: ");
int n = EnteringDimensions();

double[,] matrix = CreateMatrix(m, n);
ShowMatrix(matrix);


void Messager(string message)
{
    Console.Write(message);
}

int EnteringDimensions()
{
    return Convert.ToInt32(Console.ReadLine());
}

double[,] CreateMatrix(int m, int n)
{
    double[,] matrix = new double[m,n];
    double temp = 0;
    Random rnd = new Random();


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp = rnd.NextDouble();
            matrix[i,j] = temp + rnd.Next(-9, 10);
        }
    }
    return matrix;    
}

void ShowMatrix(double[,] matrix)
{
    for(int i =0; i<matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"|{matrix[i,j]:f1}| ");
        }
        Console.WriteLine();
    }
}