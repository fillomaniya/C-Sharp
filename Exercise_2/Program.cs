// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите чмсло 2");
int number2 = Convert.ToInt32(Console.ReadLine());

int numberMax = number1;

if(number1 > number2)
{
   Console.WriteLine(number1);
}
else
{
    Console.WriteLine(number2);
}
