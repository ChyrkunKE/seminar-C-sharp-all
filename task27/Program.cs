// программа, котрая преобразует десятичное число в двоичное


string DecinalToBinary(int number) //через строку
{
    string binary = string.Empty;
    while (number > 0)
    {
        binary = number % 2 + binary;
        number = number / 2;
    }
    return binary;
}

Console.Write("Введите десятичное число: ");
int decinalNumber = Convert.ToInt32(Console.ReadLine());
string binaryNumber = DecinalToBinary(decinalNumber);
Console.Write($"{decinalNumber} -> {binaryNumber}");





int DecinalToBinary(int number) // через число 
{
    int binary = 0;
    int mult = 1;
    while (number != 0)
    {
        binary += mult * (number % 2);
        number = number / 2;
        mult *= 10;
    }
    return binary;
}
int binar = DecinalToBinary(13);
Console.WriteLine(binar);