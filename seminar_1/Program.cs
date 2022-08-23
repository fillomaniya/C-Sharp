// Console.Write("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sqr = number * number;

// Console.WriteLine(sqr);

// Console.WriteLine("Введите число 1");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите чмсло 2");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if(number1 == number2 * number2)
// {
//     Console.WriteLine("Число 1 является квадратом числа 2");
// }
// else 
// {
//     Console.WriteLine("Число 1 не является квадратом числа 2");
// }

// Console.WriteLine("Введите число ");
// int numberDay = Convert.ToInt32(Console.ReadLine());

// if(numberDay < 1 || numberDay > 7)
// {
//     Console.WriteLine("Ошибка");
// }
// if(numberDay == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// if(numberDay == 2)
// {
//     Console.WriteLine("Вторник");
// }
// if(numberDay == 3)
// {
//     Console.WriteLine("Среда");
// }
// if(numberDay == 4)
// {
//     Console.WriteLine("Четверг");
// }
// if(numberDay == 5)
// {
//     Console.WriteLine("Пятница");
// }
// if(numberDay == 6)
// {
//     Console.WriteLine("Суббота");
// }
// if(numberDay == 7)
// {
//     Console.WriteLine("Воскресенье");
// }

// Console.WriteLine("Введите число ");

// int number = Convert.ToInt32(Console.ReadLine());
// Console.Clear();
// int numberNeg = number *(-1);
// while(numberNeg <= number)
// {
//     Console.Write(numberNeg);
//     numberNeg ++;
// }

Console.WriteLine("Введите трёхзначное число "); // Решение задачи из семинара

int number = Convert.ToInt32(Console.ReadLine());

if(number < 100 || number > 999)
{
    Console.WriteLine("Ошибка: число не трёхзначное");
}
else
{
    int number1 = number % 10;
    int number2 = number1 % 10;
    Console.WriteLine(number2);
}
