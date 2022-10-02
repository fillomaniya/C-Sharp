// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N

Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int naturalSum(int M, int N)
{
 if (M == N)
 return N;
 return N + naturalSum(M, N - 1);
}
Console.WriteLine($"Сумма элементов от {M} до {N} = {naturalSum(M, N)}");
