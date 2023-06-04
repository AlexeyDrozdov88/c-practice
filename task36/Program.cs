//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

//Вводим массив
int[] InputArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

//Метод вывода массива
void PrintArray(int[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        Console.Write(arr1[i] + " ");
    }
}

// Ищем сумму на нечетных позициях
int[] FindEvenNoneven(int[] arr2)
{
    int SumEven = 0;
    int SumNoneven = 0;
    int[] res = new int[2];
    for (int i = 0; i < arr2.Length; i++)
    {
        if ((i + 1) % 2 == 0)  SumEven+=arr2[i]; else SumNoneven+=arr2[i];
    }
    res[0] = SumEven;
    res[1] = SumNoneven;
    return res;
}


int[] array = InputArray(4, -10, 10);
PrintArray(array);
int[] result = FindEvenNoneven(array);
Console.WriteLine($"Сумма четных = {result[0]}, сумма нечетных = {result[1]}");