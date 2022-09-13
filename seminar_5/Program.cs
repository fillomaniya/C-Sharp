// Задать массив из 12 элемнтов от -9 до 9
// найти сумму всех отрицательных и положительных элементов

// int [] array = new int [12];
// int size = array.Length;

// int positiveSum = 0;
// int negativeSum = 0;
// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(-9,10);

//     if (array[i] > 0)
//     {
//         positiveSum+=array[i];
//     }
//     else
//     {
//         negativeSum+=array[i];
//     }
// }
// Console.WriteLine("Сумма положительных чисел = " + positiveSum + " | Сумма отрицательных чисел = " + negativeSum);
// Console.WriteLine(String.Join(";", array));
//----------------------------------------------
// Найти произведение пар чисел в одномерном массиве. Парой считаем 
// первый и последний элемент, второй и предпоследний и т. д.
// Результат записать в новом массиве

// int [] inputArray = {1,2,3,4,5};
// int index = inputArray.Length;

// int [] resultArray = new int [inputArray.Length/2 + inputArray.Length%2];

// for (int i = 0; i < resultArray.Length; i++)
// {
//     resultArray[i] = inputArray[i]*inputArray[inputArray.Length-1-i];

//     if (i == inputArray.Length-1-i)
//     {
//         resultArray[i] = inputArray[i];
//     }
// }
// Console.WriteLine(String.Join(",", resultArray));
// ---------------------------------------------

// Напишите программу замены элементов массива: положительные
// элементы замените на соответствующие отрицательные, и наоборот

int [] array = {-5,-7,2,4};
int size = array.Length;

for (int i = 0; i < size; i++)
{
    array[i]*=-1;
}
Console.WriteLine("[{0}]", String.Join(",", array));



