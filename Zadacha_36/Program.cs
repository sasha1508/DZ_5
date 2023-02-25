// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



int[] ArrayRnd(int size)
{
    int[] arrayTemp = new int[size];
    for(int i = 0; i < size; i++)
    {
        arrayTemp[i] = new Random().Next(100);
    }
    return arrayTemp;
}

int SumArray(int[] arrayTemp)
{
    int size = arrayTemp.Length;
    int sum = 0;
    for(int i = 1; i < size; i += 2)
    {
       sum += arrayTemp[i];
    }
    return sum;
}

int[] array = ArrayRnd(10);
int sum= SumArray(array);
Console.Clear();
Console.WriteLine($"Массив: {String.Join("; ", array)}");
Console.WriteLine($"Сумма чисел на нечётных местах в массиве: {sum}");