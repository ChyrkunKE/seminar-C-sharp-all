//  принимать навход два числа
//  выводить, является ли первое числократным второму. 
//  Если первое число не кратно второму, то программа выводит остаток от деления.
// // 34, 5 -> не кратно, остаток 4
// // 16, 4 -> кратно
int Remainder(int num1, int num2)
{
     return num1 % num2;
}
Console.WriteLine ("Введите два числа");

int firstDigit = Convert.ToInt32 (Console.ReadLine());
int secondDigit = Convert.ToInt32 (Console.ReadLine());

int remainder = Remainder (firstDigit, secondDigit);
if (remainder == 0)
    Console.WriteLine ("Кратно");
else
    Console.WriteLine($"Не кратно, остаток:{remainder}");