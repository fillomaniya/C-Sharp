// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76

int [] array = {5,55,23,4,56,8};
int max = array[0];
int min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}
for (int j = 0; j < array.Length; j++)
{
    if (array[j] < min)
    {
        min = array[j];
    }
}
Console.WriteLine("[{0}]", String.Join(",", array));
int result = max - min;
Console.WriteLine("Разница между максимальным и минимальным числами: " + result);
