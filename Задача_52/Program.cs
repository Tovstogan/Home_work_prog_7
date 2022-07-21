/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
Console.Clear();
Console.WriteLine("Задача 52");
int[,] InitMatrix(int m, int n)
{
int[,] matrix = new int[m, n];
Random randomizer = new Random();

for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
matrix[i, j] = randomizer.Next(1, 10);
}
}
return matrix;
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write($"{matrix[i, j]} ");
}
Console.WriteLine();
}
}

void AverageColumns(int[,] matr)
{
    double average = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double summ = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
            {
            summ = summ + matr[i,j];
            }
        average = summ/matr.GetLength(0);
        Console.WriteLine($"Среднее арифметическое элементов столбца {j+1} равно {average}");
        Console.WriteLine();
    }
}



Console.WriteLine("Введите число m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine());

int[,] matrix = InitMatrix(m, n);
Console.WriteLine($"Матрица размером {m}x{n}:");
Console.WriteLine();

PrintMatrix(matrix);
AverageColumns(matrix);



