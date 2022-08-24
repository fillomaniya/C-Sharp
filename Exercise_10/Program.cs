Console.WriteLine("Введите трёхзначное число: ");

int num = Convert.ToInt32(Console.ReadLine());

if(num > 999 || num < 100)
{
    Console.WriteLine("Вы ввели не трёхзначное число");
}
else
{
    int num2 = num % 100;
    int num3 = num2 / 10;
    Console.WriteLine(num3);
}