/* Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4  
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3  */

int[,] matrix = CreateMatrix(5, 5);
ShowMatrix(matrix);
double[] Answer = ArithmeticMean(matrix);
ShowArithmeticMean(Answer);

int[,] CreateMatrix(int l, int c)
{
    int[,] matrix = new int[l,c];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(0, 5);
        }
    }
    return matrix;    
}

void ShowMatrix(int[,] mat)
{
    for(int i =0; i<matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"|{mat[i,j]}| ");
        }
        Console.WriteLine();
    }
}

double[] ArithmeticMean(int[,] mat)
{
    double[] arithmetic = new double[mat.GetLength(1)];
    arithmetic[0] =0;
    for(int c= 0; c < mat.GetLength(0); c++)
    {
        for(int l =0; l < mat.GetLength(1); l++)
        {
            arithmetic[c] = (arithmetic[c] + mat[l, c]);
        }
        arithmetic[c] = arithmetic[c]/mat.GetLength(1);
    }
    return arithmetic;
}



void ShowArithmeticMean(double[] ans)
{
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for(int i =0; i<ans.Length; i++)
    {
        Console.Write($"{ans[i]:f1}; ");
    }
}