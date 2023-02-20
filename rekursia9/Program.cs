// Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”

bool Validate(int number)
{
if (number == 1)
{
return true;
}
if (number % 2 == 1)
{
return false;
}
number = number / 2;
return Validate (number);
}
System.Console.WriteLine(Validate(1));