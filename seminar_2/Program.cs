// int num = new Random().Next(10,100);
// int num1 = num / 10;
// int num2 = num % 10;
// Console.WriteLine(num);
// if(num1 > num2)
// {
//     Console.WriteLine(num1);
// }
// else
// {
//     Console.WriteLine(num2);
// }

// int num = new Random().Next(100,1000);
// int num2 = num / 100;
// int num3 = num % 10;

// Console.WriteLine(num);
// Console.Write(num2);
// Console.Write(num3);

// Console.WriteLine("Введите число 1: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int result = number2 % number1;
// if(result == 0)
// {
//     Console.WriteLine("Число кратно");
// }
// else
// {
//     Console.WriteLine("Остаток от деления: " + result);
// }

// Console.WriteLine("Введите число: ");
// Console.WriteLine("Проверим, кратно ли оно одновременно 7 и 23");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine("Число кратно");
// }
// else
// {
//     Console.WriteLine("Число не кратно");
// }

Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)
{
    Console.WriteLine($"Число {number1} является квадратом числа {number2}");
}
else
{
    Console.WriteLine($"Число {number1} не является квадратом числа {number2}");
}
if (number2 == number1 * number1)
{
    Console.WriteLine($"Число {number2} является квадратом числа {number1}");
}
else
{
    Console.WriteLine($"Число {number2} не является квадратом числа {number1}");
}