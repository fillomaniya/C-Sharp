Console.Write($"Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];

void FillArray(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введи {i + 1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int result(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;
}

FillArray(m);

Console.WriteLine($"Введено чисел больше 0: {result(array)} ");
