// Принимает на вход пятизначное число
// Проваеряет является ли оно палиндромом



bool Palindrom(int num1, int num2, int num4, int num5)
{
    if (num1 == num5 && num2 == num4)
    {
        return true;
    }
    return false;
}

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());


int number1 = number / 10000;
int number2 = number / 1000 % 10;
int number4 = number / 10 % 10;
int number5 = number % 10;

if (number <= 9999 || number > 99999)
    {
        Console.WriteLine("Некорректный ввод");
    }
else
{
    if (Palindrom(number1, number2, number4, number5))
    {
        Console.WriteLine("Да, это палиндром");
    }
    else
    {
        Console.WriteLine("Нет, это не палиндром");
    }
}
