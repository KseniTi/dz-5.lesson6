/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

void Zadacha41()
{
    Console.WriteLine("Введите длину будущего массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);

    int summ = 0;
    for (int i = 0; i < size; i++)
    {
        if (numbers[i] > 0) summ++;
    }
    Console.WriteLine("Количество положительных чисел в массиве: " + summ);

    void FillArray(int[] numbers)
    {
        int length = numbers.Length;

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("Введите число");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    void PrintArray(int[] numbers)
    {
        int length = numbers.Length;
        Console.WriteLine("Вывод массива: ");
        for (int i = 0; i < length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine("\n");
    }
}

Zadacha41();