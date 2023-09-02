// принимает на вход трёхзначное число 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// int Help (string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

Console.WriteLine ("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number<100 || number >=1000)
{
Console.WriteLine ("Повторите ввод, число не является трехзначным");
return;
}
int secondRunk  = number / 10 % 10;
Console.WriteLine(secondRunk);
