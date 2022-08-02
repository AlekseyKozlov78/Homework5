//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.


int[] GetArray(int size, int min, int max)
{
  int[] result = new int[size];

  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(min, max + 1);
  }
  return result;
}

int Sum(int [] array) 
{
  int result =0;
  for (int i = 0; i < array.Length; i++)
  {
    if (i %2 == 1 ) result += array[i];
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

//////
Console.WriteLine("Введите кол-во элементов в массиве");
int n = int.Parse(Console.ReadLine());

int[] array = GetArray(n, 0, 100);

Console.WriteLine("Заданный массив случайных чисел:");
PrintArr(array);

Console.WriteLine();
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях, равна {0}", Sum(array));