// Программа, которая перевернет массив

// int[] array = GetArray(10, 0, 10);
// Console.WriteLine(String.Join(",", array));

// ReverseArray(array);
// Console.WriteLine(String.Join(",", array));

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }
// void ReverseArray(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length / 2; i++)
//     {
//         int k = inArray[i];
//         inArray[i] = inArray[inArray.Length - 1 - i];
//         inArray[inArray.Length - 1 - i] = k;
//     }
// }
// ---------------------------------
// Напишите программу, которая проверяет введенные три числа, 
// может ли из них существовать треугольник?
// теорема о треугольнике: сумма двух сторон должна быть больше 
// третьей стороны треугольника

// Console.WriteLine("Введите число 1: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 3: ");
// int number3 = Convert.ToInt32(Console.ReadLine());

// if (number1 < number2 + number3
//     && number2 < number1 + number3
//     && number3 < number1 + number2)
// {
//     Console.WriteLine("Треугольник существует");
// }
// else
// {
//     Console.WriteLine("Треугольник не существует");
// }
//--------------------------------
// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное

// 1 способ

// int value = 53;
// string binary = Convert.ToString(value,2);

// Console.WriteLine(binary);

// 2 способ

// void ConvertNum (int num)
// {
//     string result = "";
//     while (num > 0)
//     {
//         result = num%2+result;
//         num/=2;
//     }
//     Console.WriteLine(result);
// }
// int input = Convert.ToInt32(Console.ReadLine());
// ConvertNum(input);

// Фибоначчи без рекурсии

Console.WriteLine("Введите число: ");
double num = Convert.ToInt32(Console.ReadLine());

int firstN = 0;
int secondN = 1;
Console.Write(firstN + ", ");
Console.Write(secondN);

for (int i = 3; i <= num; i++)
{
    int newN = firstN + secondN;
    Console.Write(", " + newN);
    firstN = secondN;
    secondN = newN;
}