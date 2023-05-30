// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

int Result(int[] array)
{
    int rez = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
            rez += 1;
    }
    return rez;
}

Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int[n];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Кол-во четных чисел в массиве: {Result(array)}");
