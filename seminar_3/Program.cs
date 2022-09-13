// int testNumber = 4356;

// // && || !
// bool test = testNumber == 456;

// Console.WriteLine(test);

// Console.WriteLine("Введите X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();
// if(x > 0 && y > 0)
// {
//     Console.WriteLine("1");
// }
// if(x > 0 && y < 0)
// {
//     Console.WriteLine("4");
// }
// if(x < 0 && y > 0)
// {
//     Console.WriteLine("2");
// }
// if(x < 0 && y < 0)
// {
//     Console.WriteLine("3");
// }
// if(x == 0 || y == 0)
// {
//     Console.WriteLine("Ошибка");
// }

// Console.WriteLine("Введите число четверти: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num > 4 || num < 1)
// {
//     Console.WriteLine("Ошибка");
// }
// if(num == 1)
// {
//     Console.WriteLine("x > 0, y > 0");
// }
// if(num == 2)
// {
//     Console.WriteLine("x < 0, y > 0");
// }
// if(num == 3)
// {
//     Console.WriteLine("x < 0, y < 0");
// }
// if(num == 4)
// {
//     Console.WriteLine("x > 0, y < 0");
// }

// Console.WriteLine("Введите координаты точки A: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты точки B: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());

// double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

// Console.WriteLine(result);

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i < num; i++)
{
    Console.Write(Math.Pow(i,2) + ", ");
}
Console.Write(Math.Pow(num,2));