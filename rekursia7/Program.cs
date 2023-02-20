// Напишите программу, которая будет принимать
// на вход число и возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9

int SumNumbers(int number)
{
if (number == 0)
{
return 0;
}
return SumNumbers(number / 10) + number % 10;
}
System.Console.WriteLine(SumNumbers(45));