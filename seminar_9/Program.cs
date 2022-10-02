// Задайте значение N. Напишите программу, которая
// выведет все натуральные числа в промежутке от 1 до N.

// Console.WriteLine("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int start = 1;

// string NaturalNum (int start, int N)
// {
//     if(start <= N) return $"{start}" + NaturalNum(start+1,N);
//     else return string.Empty;
// }
// Console.WriteLine($"{NaturalNum(start,N)}" + "\t");
//------------------------------------
// Задать значения M и N. Напишет программу, которая выведет
// все натуральные числа в промежутке от M до N.

// Console.WriteLine("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// string NaturalNum (int M, int N)
// {
//     if(M <= N) return $"{M} " + NaturalNum(M+1,N);
//     else Console.WriteLine("ошибка ввода чисел");
// }
// Console.WriteLine(NaturalNum(M,N));
//---------------------------------------
// Написать программу, которая будет принимать число
// и возвращать сумму его цифр

// int sum(int num)
// {
//     if(num == 0) return 0;
//     return (num%10 + sum(num/10));
// }
// Console.WriteLine(sum(453));
//----------------------------------------
// Написать программу, которая на вход принимает два числа и
// возводит первое число в степень второго числа с помощью рекурсии

int PowerNumber(int A, int B)
{
    if (B == 0) return 1;
    return A*PowerNumber(A, B-1);
}
Console.WriteLine(PowerNumber(10, 3));