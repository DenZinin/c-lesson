﻿/* Задача 4: Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

int Prompt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}
int x = Prompt("Введите число");
//Math.Pow(x, 2);// где Х - наша переменная, а 2 - степень, в которую возводим
int i = 1;
while (i <= x)
{
    double r = Math.Pow(i, 2);
    System.Console.WriteLine(r);
    i++;
}

