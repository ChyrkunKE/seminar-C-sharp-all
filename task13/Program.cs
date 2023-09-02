//  задать число
//  выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int ThirdRank(int number)
{
    while (number > 999)
    {
        number = number / 10;
    }
    return number % 10;
}

bool ValidateNumber (int number)
{
    if (number <100)
    {
        Console.WriteLine ("третьей цифры нет");
        return false;
    }
    return true;
}

Console.WriteLine("Введите число:");

int number = Convert.ToInt32(Console.ReadLine());

if (ValidateNumber(number))
{
    Console.WriteLine (ThirdRank(number));
}