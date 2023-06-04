//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76



//Вводим массив
double[] InputArray(int size)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().NextDouble()*100;
    }
    return arr;
}

//Метод вывода массива
void PrintArray(double[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        Console.Write(arr1[i] + " ");
    }
}

// Ищем разницу между максимальным и минимальным
double[] FindMinMax(double[] arr2)
{
    double MinEl = arr2[0];
    double MaxEl = arr2[0];
    double[] res = new double[2];
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i]<MinEl) MinEl=arr2[i];
        if (arr2[i]>MaxEl) MaxEl=arr2[i];
    }
    res[0] = MinEl;
    res[1] = MaxEl;
    return res;
}


double[] array = InputArray(4);
PrintArray(array);
Console.WriteLine();
double [] result = FindMinMax(array);
//PrintArray(result);
Console.WriteLine($"Минимальный = {result[0]}, максимальный = {result[1]}, разница макс-мин = {result[1]-result[0]}");