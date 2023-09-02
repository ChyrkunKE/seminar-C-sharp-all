// принимает на вход цифру, обозначающую день недели, 
// проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


bool CheckNumber(int number)
{
    if (number > 0 && number < 8)
    {
        return true;
    }
    Console.WriteLine("Ваше число больше 7, повторите ввод");
    return false;
}

bool CheckDayOfTheWeek(int number)
{
    if (number > 5)
    {
        return true;
    }
    return false;
}

Console.WriteLine("Введите цифру, обозначающую день недели:");
int number = Convert.ToInt32(Console.ReadLine());

if (CheckNumber(number))
{
    if (CheckDayOfTheWeek(number))
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
