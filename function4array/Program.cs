// Напишите программу, которая выводит массив из 8 элементов, заполненный 0 и 1 в случайном порядке



// int[] array = new int[8]; // 01234567
// // FillArray (int[]array)
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = i*i;
// }
// //PrintArray
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }


// int[] array = new int[8] {5,5,6,7,8,5,3,2};


void FullArray(int[]mass)
{
    int i = 0;
    var random = new Random();
    while (i< mass.Length)
    {
        mass[i] = random.Next(2);
        i++;
    }
}

void PrintArray(int[] mass)
{
    int i = 0;
    while (i< mass.Length)
    {
       Console.Write($"{mass[i]} ");
       i++; 
    }
}

int[]array = new int[8];
FullArray(array);
PrintArray(array);

