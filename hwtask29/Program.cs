// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]




int [] NewArray(int length, int min, int max)
{
    int[] array = new int [length];
    Random random = new Random();
    for (int i =0; i<length; i++)
    {
        array[i] = random.Next(min,max+1); 
    }
return array;
}


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}
Console.WriteLine("Задайте размер массива: ");
int lengthArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте начальное значение диапазона: ");
int minArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте конечное значение диапазона: ");
int maxArray = Convert.ToInt32(Console.ReadLine());

int[] myarray = NewArray(lengthArray,minArray,maxArray);
PrintArray(myarray);
