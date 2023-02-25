// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// Используйте NextDouble().



double[] ArrayRnd(int size)
{
    double[] arrayTemp = new double[size];
    for(int i = 0; i < size; i++)
    {
        arrayTemp[i] = Math.Round(new Random().NextDouble()*100, 3) ;
    }
    return arrayTemp;
}

//Ищем максимальное и минимальное значение юлементов массива, помещаем их в массив из двух элементов:
double[] MaxMinArray(double[] arrayTemp)
{
    double[] maxMin = new double[2];
    int size = arrayTemp.Length;
    double max = 0;
    double min = 100;
    for(int i = 1; i < size; i++)
    {
        if (max < arrayTemp[i])   max = arrayTemp[i];
        if (min > arrayTemp[i])   min = arrayTemp[i];
    }
    maxMin[0] = max; 
    maxMin[1] = min;
    return maxMin;
}

double[] array = ArrayRnd(10);
double[] мaxMin= MaxMinArray(array);
double razn = Math.Round(мaxMin[0] - мaxMin[1], 3);

Console.Clear();
Console.WriteLine($"Массив: {String.Join("; ", array)}");
Console.WriteLine($"Максимальное число массива: {мaxMin[0]}");
Console.WriteLine($"Минимальное число массива: {мaxMin[1]}");
Console.WriteLine($"Разность Max и Min: {razn}");
