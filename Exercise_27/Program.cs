// Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int SumNumber(int num)
// { 
// int count = Convert.ToString(num).Length;
// int advance = 0;
// int result = 0;

// for (int i = 0; i < count; i++)
//     {
//         advance = num - num % 10;
//         result = result + (num - advance);
//         num = num / 10;
//     }
//     return result;
// }

// int sumNumber = SumNumber(num);
// Console.WriteLine("Сумма цифр в числе: " + sumNumber);

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int GetSum(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum+=number%10;
        number/=10;
    }
    return sum;
}
Console.WriteLine(GetSum(num));