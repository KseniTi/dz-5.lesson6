/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

void Zadacha41()
{
    /*Console.WriteLine("Введите число");
    string numbers = Console.ReadLine();*/

    int[] numbers = {0, 7, 8, -2, -2};

    int summ = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0) summ++;
    }
    Console.WriteLine(summ);
}


Zadacha41();