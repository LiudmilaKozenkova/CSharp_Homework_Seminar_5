// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным
// элементов массива. Например, [3 7 22 2 78] -> 76

// 1. Метод получения псевдослучайного числа от min до max
int GetIntValue(int min, int max)
{
    return new Random().Next(min, max);
}

// 2. Создать массив
int[] CreateArray(int size)
{
    return new int[size];
}

// 3. Заполнить массив случайными вещественными числами
void Fill(int[] array, int min, int max)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = GetIntValue(-100, 100);
    }
}

// 4. Распечатать массив
void Print(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// 5. Найти max елемент массива
int SearchMax(int[] data)
{
    int count = data.Length;
    int max = data[0];
    for (int i = 0; i < count; i++)
    {
        if (data[i] > max) max = data[i];
    }
    return max;
}

// 6. Найти min элемент массива
int SearchMin(int[] data)
{
    int count = data.Length;
    int min = data[0];
    for (int i = 0; i < count; i++)
    {
        if (data[i] < min) min = data[i];
    }
    return min;
}

// 7. Разница между max и min элементами массива
int Diff(int[] array)
{
    int T = SearchMax(array)-SearchMin(array);
    return T;
}

int[] array = CreateArray(GetIntValue(4, 6));
Fill(array, -100, 100);
Print(array);
Console.Write("Максимальное число = ");
Console.WriteLine(SearchMax(array));
Console.Write("Минимальное число = ");
Console.WriteLine(SearchMin(array));
Console.Write("Разница между max и min элементами массива = ");
Console.WriteLine(Diff(array));
