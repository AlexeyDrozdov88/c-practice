//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


//ввод целых чисел
int Input(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine());
    return num;
}


// ввод массива 
int[,] Fillarray(int m, int n, int minvalue, int maxvalue)

{
    int[,] matr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matr[i, j] = new Random().Next(minvalue, maxvalue + 1);
        }
    }
    return matr;
}

// вывод массива
void Printarray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Ищем строку с макс суммой    
void FindMaxRow(int[,] matr)
{
    int MaxRow = -1;
    int temp = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int SumRow = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            SumRow = SumRow + matr[i, j];
        }
        if (SumRow > temp)
        {
            MaxRow = i;
            temp = SumRow;
        }
    }
    Console.WriteLine($"Строка с максимальной суммой элеметнов -> {MaxRow + 1}");
}

int rows = Input("Введи кол-во строк: ");
int columns = Input("Введи кол-во столбцов: ");
int minel = Input("Введи минимальный элемент массива: ");
int maxel = Input("ВВведи максимальный элемент массива: ");
int[,] matrix = Fillarray(rows, columns, minel, maxel);
Printarray(matrix);
FindMaxRow(matrix);