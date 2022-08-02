// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetArray(int size, int min, int max)
{
  int[] result = new int[size];

  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(min, max + 1);
  }
  return result;
}

int Count(int [] array) 
{
  int result =0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] %2 == 0 ) result += 1;
  }
  return result;
}
void PrintArr (int[] array3)
{
Console.Write("[");
foreach (int item in array3)
{
  Console.Write(item + ",");}
Console.Write("]");
}


Console.WriteLine("Введите кол-во элементов в массиве");
int n = int.Parse(Console.ReadLine());

int[] array = GetArray(n, 100, 999);

Console.WriteLine("Заданный массив положительных трёхзначных чисел:");
PrintArr(array);

Console.WriteLine();
Console.WriteLine("Количество чётных чисел в массиве {0}", Count(array));