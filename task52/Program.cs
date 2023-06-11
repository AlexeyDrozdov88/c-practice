//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

// Ищем среднее арифметическое по столбцу
 void FindAverage (int[,] matr)
 {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double avg = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            avg = avg + matr[i,j] ;
        }
        avg = avg / matr.GetLength(0);
        Console.WriteLine($"Ср. арифм. {j+1}-го столбца равно: {Math.Round(avg,1)}");
    }
 }


int rows = Input("Введи кол-во строк: ");
int columns = Input("Введи кол-во столбцов: ");
int minel = Input("Введи минимальный элемент массива: ");
int maxel = Input("ВВведи максимальный элемент массива: ");
int[,] matrix = Fillarray(rows, columns, minel, maxel);
Printarray(matrix);
FindAverage(matrix);