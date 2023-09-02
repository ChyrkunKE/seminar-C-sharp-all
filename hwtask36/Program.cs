//  Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int SumNotEvenDig(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) result = result + arr[i]; // позиция = индекс элемента. 
        // если нужна позиция в массиве (без нулевой) i%2 == 0
    }
    return result;
}

int[] array = CreateArrayRndInt(4, 1, 100);
PrintArray(array);
Console.WriteLine();
int number = SumNotEvenDig(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {number}");