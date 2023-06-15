//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

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

// Упорядочиваем строки по убыванию
int[,] SortedRows(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int k = 0; k < matr.GetLength(1); k++)
        {
            for (int j = 0; j < matr.GetLength(1) - 1; j++)
            {
                if (matr[i, j + 1] > matr[i, j])
                {
                    int t = matr[i, j];
                    matr[i, j] = matr[i, j + 1];
                    matr[i, j + 1] = t;
                }
            }
        }

    }
    return matr;
}

int rows = Input("Введи кол-во строк: ");
int columns = Input("Введи кол-во столбцов: ");
int minel = Input("Введи минимальный элемент массива: ");
int maxel = Input("ВВведи максимальный элемент массива: ");
int[,] matrix = Fillarray(rows, columns, minel, maxel);
Printarray(matrix);
Printarray(SortedRows(matrix));