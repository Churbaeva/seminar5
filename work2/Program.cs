//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] arr = GetRandomArray(10);
PrintArray(arr);
Console.WriteLine(GetSumOdd(arr));

int GetSumOdd(int[] array)
{
    int sum=0;
    for (int i=1; i<array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    
    return sum;
}


int[] GetRandomArray(int Length)
{
int[] result = new int[Length];

    for (int i=0; i<Length; i++)
    {
        result[i]=new Random().Next(0,10);
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
