
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


// Сколько чисел вводим
int InputNumber(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine());
    return num;
}
int val = InputNumber("Сколько чисел будете вводить");

//Метод ввода массива
int[] array = new int[val];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i+1}е число");
    array[i] = int.Parse(Console.ReadLine());
}


// Ищем кол-во чисел больше 0

int PositiveNumber(int[] arr)
{
    int pos = 0;
    for (int i = 0; i < array.Length; i++)
        if (arr[i] > 0) pos++;
    return pos;
}
Console.WriteLine($"Вы ввели {PositiveNumber(array)} положительных чисел");