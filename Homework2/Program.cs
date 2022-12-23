//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

Console.WriteLine("введите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
ArrayRandomNumbers(array);
PrintArray(array);
ReturnArray(array);

void ArrayRandomNumbers(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = new Random().Next(1,100);
}
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
        Console.Write($"{array[i, j]} ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


void ReturnArray(int[,] array)
{
Console.WriteLine("введите строку");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите столбец");
int b = int.Parse(Console.ReadLine());
 if ( a>=m || b>=n)
 Console.WriteLine("Такого числа в массиве нет");
 else
 {
 object result = array.GetValue(a,b);
 Console.WriteLine(result);
 }
}