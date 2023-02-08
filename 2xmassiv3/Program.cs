﻿// Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные,
// и замените эти элементы на их квадраты.

int[,] GenereteArray(int row, int col)
{
int[,] array = new int[row, col];
for (int i = 0; i < row; i++)
{
for (int j = 0; j < col; j++)
{
array[i, j] = new Random().Next(0, 10);
}
}
return array;
}
void PrintArray(int[,] array)
{
int row = array.GetLength(0);
int col = array.GetLength(1);
for (int i = 0; i < row; i++)
{
for (int j = 0; j < col; j++)
{
System.Console.Write($"{array[i, j]}\t");
}
System.Console.WriteLine();
}
}

void Power2EvenInd(int[,] array)
{
int row = array.GetLength(0);
int col = array.GetLength(1);
for (int i = 1; i < row; i+=2) // через 1
{
for (int j = 1; j < col; j+=2)
{
array[i, j] *= array[i, j];
}
}
}

int [,] array = GenereteArray(3, 4);
PrintArray(array);
System.Console.WriteLine();
Power2EvenInd(array);