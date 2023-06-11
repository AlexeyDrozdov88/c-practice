//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

//ввод целых чисел
int Input(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine());
    return num;
}


// ввод массива 
double[,] Fillarray(int m, int n)

{
    double[,] matr = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double temp = 0;
            temp = new Random().NextDouble();
            double sign = 0;
            sign = new Random().Next(-1, 1);
            if (sign == 0) sign = 1;
            matr[i, j] = Math.Round(temp*10,1)*Math.Round(sign, 0);
            
        }
    }
    return matr;
}

// вывод массива
void Printarray(double[,] matr)
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

int rows = Input("Введи кол-во строк: ");
int columns = Input("Введи кол-во столбцов: ");
double[,] matrix = Fillarray(rows, columns);
Printarray(matrix);