
//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int NumberRate (int number, int rate)
{
    int result = 1;
    for (int i = 0; i < rate; i++)
    {
        result *= number;
    } 
    return result;
}

bool PositiveRate (int rate)
{
    if (rate<0)
    {
        Console.WriteLine ("Число В не должно быть меньше 0");
        return false;
    }
    return true;
}

Console.WriteLine("Введите число А: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (PositiveRate(num2))
{
    Console.WriteLine($"Число {num1} в степени {num2} равно {NumberRate(num1,num2)}");
}

