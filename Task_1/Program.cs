//Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве. Например, [345, 897, 568, 234] -> 2

//Получения псевдослучайного числа от min до max
int GetIntValue(int min, int max)
{
    return new Random().Next(min, max);
}

// 1. Задать массив, в кот хранятся элементы
int[] CreateArray(int size)
{
    return new int[size];
}

// 2. Заполнить массив случайными положительными трехзначными числами
void Fill(int[] array, int min, int max)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = GetIntValue(100, 1000);
    }
}

// 3. Распечатать исходный массив
void Print(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
        i++;
    }
    Console.WriteLine();
}

// 4. Найти количество четных чисел в массиве
int Final(int[] col)
{
    int count = 0;
    int size = col.Length;
    for (int i = 0; i < size; i++)
    {
        if (col[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}


int[] data = CreateArray(GetIntValue(5, 7));
Print(data);
Fill(data, 100, 1000);
Print(data);
int EvenElements = Final(data);
Console.WriteLine(EvenElements);