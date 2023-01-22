// Задача 1: Напишите программу, которая принимает на вход число (А)
//  и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumNumbers(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

int SumNumbersGauss(int number)
{
    return (number + 1)*number/2;
}

int number = Prompt("Введите число");
int sum = SumNumbers(number);
System.Console.WriteLine($"Сумма чисел от 1 до {number} равна {sum}");
System.Console.WriteLine($"Сумма чисел по Гауссу от 1 до {number} равна {SumNumbersGauss(number)}");

