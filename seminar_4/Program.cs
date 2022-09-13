// Console.WriteLine("Введите число A: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Сумма = " + GetSum(num));

// int GetSum(int number)
// {
//     int sum = 0;
//     int count = 0;

//     while(number > count)
//     {
//         count++;
//         sum+=count;
//     }
//     return sum;
// }

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string result = Convert.ToString(num);
// Console.WriteLine("Количество цифр в этом числе: " + amount(result));

// int amount(string num)
// {
//     int size = num.Length;
//     return size;
// }

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Количество цифр в этом числе: " + GetCount(num));

// int GetCount(int number)
// {
//     int count = 0;
//     while(number > 0)
//     {
//         count++;
//         number/=10;
//     }
//     return count;
// }

// Console.WriteLine("Введите число N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Произведение чисел от 1 до N: " + GetCount(num));

// int GetCount(int number)
// {
//     int pr = 1;
//     int count = 0;
//     while(number > count)
//     {
//         count++;
//         pr *= count;
//     }
//     return pr;
// }

// int[]array = GetArray(8);
// Console.WriteLine(string.Join(",", array));

// int[] GetArray(int size)
// {
//     int [] result = new int [size];
//     for (int i = 0; i < size; i++);
//     {
//         result[i] = new Random().Next(0,2);
//     }
//     return result;
// }

// вывести массив, заполненный случайным образом из 0 и 1, 
// состоящий из 8 элементов

int[] array = new int[8];
// заполняем массив
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(0,2);
        index++;
    }
}
// выводим массив
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position]);
        position++;
    }
}
FillArray(array);
PrintArray(array);