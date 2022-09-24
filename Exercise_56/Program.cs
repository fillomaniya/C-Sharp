// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

Console.WriteLine("введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix = new int[rows, columns];
FillArray(matrix);
PrintArray(matrix);
int minSum = int.MaxValue;
int indexRows = 0;
int sum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];        
    }
    if (sum < minSum)
    {
        minSum = sum;
        indexRows++;
    }
}

Console.WriteLine("строка с наименьшей суммой элементов: " + (indexRows) + ", где сумма: " + (minSum));

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