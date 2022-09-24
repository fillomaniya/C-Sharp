// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.

Console.WriteLine("введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, columns];
FillArray(matrix);
Console.WriteLine();
Console.WriteLine("Первоначальный массив:");
PrintArray(matrix);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < matrix.GetLength(1) - 1; z++)
        {
            if (matrix[i, z] < matrix[i, z + 1])
            {
                int temp = 0;
                temp = matrix[i, z];
                matrix[i, z] = matrix[i, z + 1];
                matrix[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Результат:");
PrintArray(matrix);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}