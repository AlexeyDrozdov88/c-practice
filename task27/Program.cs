//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int InputNumber(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int number = InputNumber("Введите  число");


int SearchSumOfNumbers(int n)
{
    int sumofnum = 0;
    for (int i = n; i > 0; i /= 10)
    {
        sumofnum = sumofnum + i % 10;
    }
    return sumofnum;
}

Console.WriteLine($"Сумма цифр числа {number} равнa {SearchSumOfNumbers(number)}");