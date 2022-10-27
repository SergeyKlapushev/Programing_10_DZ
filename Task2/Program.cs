/*Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4 */

int[,] matrix = CreateMatrix(5, 5);

Messager("Ведите номер строки матрицы: ");
int line = Number();

Messager("Ведите номер стобца матрицы: ");
int column = Number();

ShowMatrix(matrix);
ShowAnswer(line, column, matrix);


void Messager(string message)
{
    Console.Write(message);
}

int Number()
{
    return Convert.ToInt32(Console.ReadLine());
}

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


void ShowMatrix(int[,] matrix)
{
    for(int i =0; i<matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"|{matrix[i,j]}| ");
        }
        Console.WriteLine();
    }
}

void ShowAnswer(int l, int c, int [,] m)
{
    if(l>0 && c>0)
    {
        if(l<= m.GetLength(0) && c<=m.GetLength(1))
        {
            l--;
            c--;
            Console.WriteLine(m[l,c]);
        }
        else{Console.WriteLine($"[{l},{c}] -> такого числа в массиве нет");}
    }
    else{Console.WriteLine($"[{l},{c}] -> такого числа в массиве нет");}

}