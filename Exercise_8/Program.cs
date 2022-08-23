// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.Write("Введите число: ");
// int number1 = 1;
// int number2 = Convert.ToInt32(Console.ReadLine());

// for (int i = number1; i <= number2; i++)
// {
//     if (i % 2 == 0) 
//     {
//         Console.Write(i + " ");
//     }
// }

Console.Write("Введите число: ");
int number1 = 1;
int number2 = Convert.ToInt32(Console.ReadLine());
int i = number1;
while (i <= number2)
{
    if (i % 2 == 0) 
    {
        Console.Write(i + " ");
    }
    i ++;
}