// принимает число n
// выдает произведение чисел от 1 до n


int FactorialNumbers(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {  
        mult *= i; 
        }
    }
    return mult;
}

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine("Введено некорректное число");
    return;
}
else
{
int factorialNumbers = FactorialNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {factorialNumbers}");
}