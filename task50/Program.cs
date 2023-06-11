//Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//[1,7] -> такого числа в массиве нет [1,7]-это позиция элемента 1 - строка, 7 - столбец

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

//Ищем элемент в массиве или говорим, что такого нет
void FindElement(int[,] matr,int m, int n)
{
 if (m > matr.GetLength(0) && n > matr.GetLength(1)) Console.WriteLine("Такого элемента нет");
 else Console.WriteLine($"Элемент {m}й строки и {n}го столбца равен: {matr[m-1,n-1]}");
}

int rows = Input("Введи кол-во строк: ");
int columns = Input("Введи кол-во столбцов: ");
int minel = Input("Введи минимальный элемент массива: ");
int maxel = Input("ВВведи максимальный элемент массива: ");
int[,] matrix = Fillarray(rows, columns, minel, maxel);
Printarray(matrix);
int needRow = Input("Введи строку искомого элемента: ");
int needCol = Input("Введи столбец искомого элемента: ");
FindElement(matrix,needRow,needCol);