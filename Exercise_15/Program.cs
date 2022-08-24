Console.WriteLine("1 = пн, 2 = вт, 3 = ср, 4 = чт, 5 = пт, 6 = сб, 7 = вс");
Console.Write("Введите число, я покажу, выходной этот день или нет: ");
int numberDay = Convert.ToInt32(Console.ReadLine());

if(numberDay < 1 || numberDay > 7)
{
    Console.WriteLine("Ошибка");
}
if(numberDay == 1)
{
    Console.WriteLine("нет");
}
if(numberDay == 2)
{
    Console.WriteLine("нет");
}
if(numberDay == 3)
{
    Console.WriteLine("нет");
}
if(numberDay == 4)
{
    Console.WriteLine("нет");
}
if(numberDay == 5)
{
    Console.WriteLine("нет");
}
if(numberDay == 6)
{
    Console.WriteLine("да");
}
if(numberDay == 7)
{
    Console.WriteLine("да");
}