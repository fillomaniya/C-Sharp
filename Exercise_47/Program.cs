// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

Console.WriteLine("Задайте количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double [m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix [i,j] = Convert.ToDouble(new Random().Next(-100,100)) / 10;
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}