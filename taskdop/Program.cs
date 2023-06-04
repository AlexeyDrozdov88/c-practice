//Изменить положительные элементы на отрицательные и наоборот

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
    Console.WriteLine();
}

// Меняем 
int[] ChangeArray(int[] arr2)
{
    int[] res = new int[arr2.Length];
    for (int i = 0; i< arr2.Length; i++)
    {
    res[i]= arr2[i]*-1;    
    }
    return res;
}


int[] array = InputArray(4, -10, 10);
PrintArray(array);
int[] result = ChangeArray(array);
PrintArray(result);