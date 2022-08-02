// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

double[] GetArray(int size, int min, int max)
{
  double[] result = new double[size];

  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(min, max + 1);
  }
  return result;
}

double Sub(double [] array) 
{
  double result =0;
  double maxItem = array[0];
  double minItem = array[0];
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i]> maxItem) maxItem = array[i];
    if (array[i]< minItem) minItem = array[i];
  }
  return result = maxItem - minItem ;
}
void PrintArr (double[] array3)
{
Console.Write("[");
foreach (double item in array3)
{
    Console.Write(item + ",");}
    Console.Write("]");
}


Console.WriteLine("Введите кол-во элементов в массиве");
int n = int.Parse(Console.ReadLine());

double[] array = GetArray(n, 0, 100);

Console.WriteLine("Заданный массив случайных чисел:");
PrintArr(array);

Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальным элементами массива, равна {0}", Sub(array));