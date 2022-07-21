/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/

Console.Clear();
Console.WriteLine("Задача 50");
int GetNumber(string message)
{
    int result = 0;
    string error = "Введите корректное число ";

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result)) 
        {
            break;
        }
        else 
        {
            Console.Clear();
            Console.WriteLine(error);
        }
    }

    return result;
}

int [,] InitMatrix(int m, int n)
{
int [,] matrix = new int[m,n];
Random randomizer = new Random();

for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
matrix[i,j] = randomizer.Next(1,10);
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
int number = GetNumber("Введите число: ");
void FindNumber(int[,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == number)
            {
                Console.WriteLine($"Число {number} есть в матрице.");
            }
            else 
            {
                Console.WriteLine($"Числа {number} нет в матрице.");
            }
        }
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
FindNumber(matrix);
