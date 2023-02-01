//Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] arr = GetRandomArray(10);
PrintArray(arr);
Console.WriteLine(GetEvenNumber(arr));

int GetEvenNumber(int[] array)
{
    int result=0;
 for (int i=0; i<array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}


int[] GetRandomArray(int Length)
{
    int[] result = new int[Length];

    for (int i=0; i<Length; i++)
    {
        result[i]=new Random().Next(100, 1000);
    }
    return result;
}

void PrintArray(int[] arr)
{
    foreach(int item in arr)
    
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
