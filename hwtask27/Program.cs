// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int DigitSum(int num)
{
    int result = 0;
    while (num != 0)
    {
        result += num % 10;
        num = num/10;
    }
    return result;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int summa = DigitSum (number);
Console.Write($"Сумма цифр в числе {number} равна {summa}");
