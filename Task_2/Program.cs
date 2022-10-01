//Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях. Например, [3, 7, 23, 12] -> 19
//                                         [-4, -6, 89, 6] -> 0

// 1. Метод получения псевдослучайных чисел
int GetIntValue(int min, int max)
{
    return new Random().Next(min, max);
}

// 2. Создать массив
int[] Create(int size)
{
    return new int[size];
}

// 3.Заполнить массив случайными числами
void Fill(int[] array, int min, int max)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = GetIntValue(1, 10);
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

// 5. Найти сумму элементов, стоящих на нечетных позициях
int SumUnevenPosNumbers(int[] collection)
{
    int sum = 0;
    int count = collection.Length;
    for (int i = 1; i < count; i += 2)
    {
        sum = sum + collection[i];
    }
    return sum;
}
int[] set = Create(GetIntValue(3, 6));
Fill(set, 1, 10);
Print(set);
Console.WriteLine(SumUnevenPosNumbers(set));