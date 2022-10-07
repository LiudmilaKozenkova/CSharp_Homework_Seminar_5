// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным
// элементов массива. Например, [3 7 22 2 78] -> 76

// 1. Создать и заполнить массив вещественных чисел
double[] CreateFillArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 100) / 10.0;
    }
    return array;
}

// 2. Распечатать массив
void Print(double[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// 3. Найти max елемент массива
double SearchMax(double[] data)
{
    int count = data.Length;
    double max = data[0];
    for (int i = 0; i < count; i++)
    {
        if (data[i] > max) max = data[i];
    }
    return max;
}

// 4. Найти min элемент массива
double SearchMin(double[] data)
{
    int count = data.Length;
    double min = data[0];
    for (int i = 0; i < count; i++)
    {
        if (data[i] < min) min = data[i];
    }
    return min;
}

// 7. Разница между max и min элементами массива
    
double[] coll = CreateFillArray(5);
Print(coll);
Console.Write("Максимальное число = ");
Console.WriteLine(SearchMax(coll));
Console.Write("Минимальное число = ");
Console.WriteLine(SearchMin(coll));
Console.Write("Разница между max и min элементами массива = ");
Console.WriteLine(SearchMax(coll) - SearchMin(coll));
