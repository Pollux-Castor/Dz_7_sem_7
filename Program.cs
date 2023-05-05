// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// Console.WriteLine("Введите число строк");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// double [,] array = new double [rows,columns];

// for (int i = 0; i<array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = Math.Round((new Random().NextDouble()),1) + new Random().Next(-10,9);
//         Console.Write(array[i,j]+ " | ");
//     }

// Console.WriteLine();
// }

//-------------------------------------------------------------------------------------------

// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("Введите число строк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

double [,] array = new double [rows,columns];

Console.WriteLine("Введите номер строки");
int rows2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца");
int columns2 = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i<array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(0,10);
        Console.Write(array[i,j]+ " | ");
    }

Console.WriteLine();
}
if (rows2<=rows+1 && columns2<=columns+1)
{
Console.WriteLine($"Значение элемента равно: " +array[rows2-1,columns2-1]);
}
else
{
Console.WriteLine("Cтроки: "+rows2+" ,или столбца: "+columns2+" в массиве нет");
}

