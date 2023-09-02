// Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int [] NewArray(int size)
{
    int [] arr = new int [size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
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

int PositiveNumbers (int[] arr)
{
    int count =0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0)
        {
            count = count+1;
        }
    }
    return count;
}

Console.WriteLine("Сколько чисел вы хотите ввести: ");
int sizearr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите {sizearr} чисел:  ");
int [] newArray = NewArray(sizearr);
PrintArray(newArray);
int result = PositiveNumbers (newArray);
Console.WriteLine($"Положительных чисел {result}");

