// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] ArrayRnd(int size)
{
    int[] arrayTemp = new int[size];
    for(int i = 0; i < size; i++)
    {
        arrayTemp[i] = new Random().Next(100, 1000);
    }
    return arrayTemp;
}

int CountArray2(int[] arrayTemp)
{
    int size = arrayTemp.Length;
    int count = 0;
    for(int i = 0; i < size; i++)
    {
        if (arrayTemp[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = ArrayRnd(10);
int Count= CountArray2(array);
Console.Clear();
Console.WriteLine($"Массив: {String.Join("; ", array)}");
Console.WriteLine($"Количество чётных чисел в массиве: {Count}");
