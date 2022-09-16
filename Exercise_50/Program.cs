// Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

int rows = Convert.ToInt32(new Random().Next (1,10));
int columns = Convert.ToInt32(new Random().Next (1,10));

int [,] matrix = new int [rows,columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,10);
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("введите номер строки");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int n = Convert.ToInt32(Console.ReadLine());

if (m > matrix.GetLength(0) || n > matrix.GetLength(1) 
    || m == 0 || n == 0 || m < 0 || n < 0)
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {m} строки и {n} столбца равно {matrix[m-1,n-1]}");
}