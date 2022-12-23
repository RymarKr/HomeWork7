//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("введите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
int[] summ = new int[m];
ArrayRandomNumbers(array);
PrintArray(array);
ArithmeticMeanOfElements(array);

void ArrayRandomNumbers(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = new Random().Next(1,10);
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

void ArithmeticMeanOfElements(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        summ[i] += array[j, i];
    }
}
            foreach (double result in summ)
            {
           Console.Write($"{Math.Round(result/m,1)}; ");
            }
    }