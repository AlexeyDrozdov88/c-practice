//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18


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

// Перемножаем массивы  
int[,] multi(int[,] matr1, int[,] matr2, int siz)
{
    int[,] matrOut = new int[siz, siz];
    for (int k = 0; k < matr1.GetLength(0); k++)
    {
        for (int i = 0; i < matr1.GetLength(0); i++)
        {
            int ele = 0;
            for (int j = 0; j < matr1.GetLength(1); j++)
            {
                ele = ele + matr1[i, j] * matr2[j, i];
            }
            matrOut[i, k] = ele;
        }

    }
    return matrOut;
}


int size = Input("Введи размерность массива: ");
int minel = Input("Введи минимальный элемент массива: ");
int maxel = Input("ВВведи максимальный элемент массива: ");
int[,] matrix1 = Fillarray(size, size, minel, maxel);
int[,] matrix2 = Fillarray(size, size, minel, maxel);
Printarray(matrix1);
Console.WriteLine();
Printarray(matrix2);
Console.WriteLine();
Printarray(multi(matrix1, matrix2, size));