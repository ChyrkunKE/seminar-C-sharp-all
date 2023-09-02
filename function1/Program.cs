// принимает число А
// выдает сумму чисел от 1 до А


int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
        sum += i; // sum = sum + 1
        }
    }
    return sum;
}

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
if (number < 1)
{
    Console.WriteLine("Введено некорректное число");
    return;
}
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");