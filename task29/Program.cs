//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]



// ввод размера массива
int InputNumber(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine());
    return num;
}
int val = InputNumber("Введите размер массива");

//Метод ввода массива


int[] array = new int[val];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i}й элемент массива");
    array[i] = int.Parse(Console.ReadLine());
}


//Метод вывода массива
void PrintArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write(array1[i] + " ");
    }
}
PrintArray(array);