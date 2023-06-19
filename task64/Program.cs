//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


//ввод целых чисел
int Input(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine());
    return num;
}


void Print1toN(int N, int count)
{
    if (count > 1)
    {
        Console.Write(count + ", ");
        Print1toN(N, count -1);
    }
    else Console.Write(1);
}


int size = Input("Введи число N: ");
int i = size;
Print1toN(size, i);

