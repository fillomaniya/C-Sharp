// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом

// int num = new Random().Next(10000,100000);
// Console.WriteLine(num);

// string num2 = num.ToString();
// if(num2[0] == num2[4] && num2[1] == num2[3])
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }
Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 10000 || num > 100000)
{
    Console.WriteLine("Ошибка. Число не пятизначное");
}
else
{
    string num2 = num.ToString();
    if(num2[0] == num2[4] && num2[1] == num2[3])
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}