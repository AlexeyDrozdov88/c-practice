//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29


//ввод целых чисел
int Input(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine());
    return num;
}


int AKK(int n, int m)
{
    while (n != 0)
    {
        if (m == 0) m = 1;
        else m = AKK(n, m - 1);
        n = n - 1;
    }
    return m + 1;
}

int m = Input("Введи число M: ");
int n = Input("Введи число N: ");
Console.WriteLine(AKK(m, n));