// Задача 2: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


int Prompt(string msg)
{
    System.Console.WriteLine($"{msg} : ");
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

int Factorial(int n)
{
    int prod = 1;
    for (int i = 1; i<=n; i++)
    {
        prod = prod * i;
    }
    return prod;
    
}

int usernumber = Prompt("Введите число: ");

int res = Factorial(usernumber);

Console.WriteLine($"Факториал числа {usernumber} равен {res}");