//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)






// Ввод координат
int koord(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int k1 = koord("Введите k1");
int b1 = koord("Введите b1");
int k2 = koord("Введите k2");
int b2 = koord("Введите b2");

if (k1 == k2)
{
    Console.WriteLine("Линии параллельны");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * x + b1);
    Console.WriteLine($"Линии пересекутся в точке {x},{y}");
}