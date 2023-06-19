//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


//ввод целых чисел
int Input(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine());
    return num;
}


int SumMtoN(int M,int N)
{
    if ( M == N) return M;
    else return N + SumMtoN(M,N-1);
}

int m = Input("Введи число M: ");
int n = Input("Введи число N: ");
Console.WriteLine(SumMtoN(m,n));