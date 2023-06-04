//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

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

// Ищем кол-во четных и нечетных
int[] FindEvenNoneven(int[] arr2)
{
    int even = 0;
    int noneven = 0;
    int[] res = new int[2];
    foreach (int el in arr2)
    {
        if (el % 2 == 0) even += 1; else noneven += 1;
    }
    res[0]=even;
    res[1]=noneven;
    return res;
}


int[] array = InputArray(4, 100, 999);
PrintArray(array);
int[] result =  FindEvenNoneven(array);
Console.WriteLine($"Четных - {result[0]}, нечетных - {result[1]}");