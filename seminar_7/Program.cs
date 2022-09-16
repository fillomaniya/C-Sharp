// Задайте двумерный массив размером mxn, 
// заполненный случайными целыми числами

// Console.WriteLine("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int [rows,columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(0,11);
//         Console.Write(matrix[i,j] + "\t");
//     }
//     Console.WriteLine();
// }
// ---------------------------------------------
// Задайте двумерный массив размера m на n
// каждый элемент в массиве находится по формуле
// Amn = m+n

// Console.WriteLine("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int [rows,columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = i+j;
//         Console.Write(matrix[i,j] + "\t");
//     }
//     Console.WriteLine();
// }
// ---------------------------------------------
// Задать массив двумерный. Найти элементы, 
// у которых оба индекса четыне
// заменить эти элементы на их квадраты

// Console.WriteLine("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double [,] matrix = new double [rows,columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(0,10);
//         Console.Write(matrix[i,j] + "\t");
//     }
//     Console.WriteLine();
// } 
// Console.WriteLine(); 
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if (i % 2 == 0 && j % 2 == 0)
//         {
//             matrix[i,j] = Math.Pow(matrix[i,j], 2);
//         }
//         Console.Write(matrix[i,j] + "\t");
//     }
//     Console.WriteLine();
// }
// -----------------------------------------
// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали

Console.WriteLine("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [rows,columns];
int sum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,10);
        if (i == j)
        {
            sum += matrix[i,j];
        }
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine($"Сумма - " + (sum));