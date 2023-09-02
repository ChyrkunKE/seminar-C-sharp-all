// принимает на вход два числа
// проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


bool CheckSquare(int firstNumber, int secondNumber)
{
    return firstNumber * firstNumber == secondNumber || secondNumber * secondNumber == firstNumber;
}
Console.WriteLine("Введите два числа:");

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = CheckSquare (number1, number2);

Console.WriteLine(result ? "да" : "нет");
