Console.WriteLine("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

if(num > 99)
{
    Console.WriteLine(num.ToString()[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}