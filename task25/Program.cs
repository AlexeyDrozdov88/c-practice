//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


int InputNumber(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int number1 = InputNumber("Введите первое число");
int number2 = InputNumber("Введите второе число");


int SearchPow(int n1, int n2)
{
    int pow = n1;
    for (int i = 2; i <= n2; i++)
    {
        pow = pow * n1;
    }
    return pow;
}
Console.WriteLine($"{number1} в степени {number2} равно {SearchPow(number1, number2)}");