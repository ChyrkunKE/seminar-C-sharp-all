// Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и
//   минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double [] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}
void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]:F1}");
    }
    Console.Write("]");
}

double MaxDigit(double[] arr)
{
    double maxDigit = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxDigit) maxDigit = arr[i];
    }
    return maxDigit;
}

double MinDigit(double[] arr)
{
    double minDigit = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minDigit) minDigit = arr[i];
    }
    return minDigit;
}

double[] array = CreateArrayRndDouble(5, 1, 100);
PrintArrayDouble(array);
double maxResult = MaxDigit(array);
double minResult = MinDigit(array);
Console.WriteLine($" => {maxResult} - {minResult} = {(maxResult - minResult):F2}");