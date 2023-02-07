// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


int[] GenerateArray(int len)
{
int[] array = new int[len];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = rnd.Next(-9, 10);
}
return array;
}

int[] Reverse(int[] array)
{
for (int i = 0; i < array.Length / 2; i++)
{
int temp = array[i];
array[i] = array[array.Length - 1 - i];
array[array.Length - 1 - i] = temp;
}
return array;
}

void PrintArray(int[] array)
{
foreach (int item in array)
{
System.Console.Write($"{item}\t");
}
System.Console.WriteLine();
}

int[] array = GenerateArray(5);
PrintArray(array);
PrintArray(Reverse(array));