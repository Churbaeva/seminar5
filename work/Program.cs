 //Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


double[] arr = GetRandomArray(10);
PrintArray(arr);
System.Console.WriteLine($"Минимальное значение массива {GetDifferenceMin(arr)}, максимальное значение массива {GetDifferenceMax(arr)}");
System.Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {GetDifferenceMax(arr) - GetDifferenceMin(arr)}");

double GetDifferenceMax(double[] array)
{
// int result = 0;
double max = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] > max)
{
max = array[i];
}
}
return max;
}

double GetDifferenceMin(double[] array)
{
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
if (array[i] < min)
{
min = array[i];
}
}
return min;
}

double[] GetRandomArray(int Length)
{
double[] array = new double[Length];

for (int i = 0; i < Length; i++)
{
    array[i] = new Random().NextDouble() * 100;
}
return array;
}

void PrintArray(double[] arr)
{
foreach (double item in arr)

{
    Console.Write(item + " ");
}
Console.WriteLine();
}