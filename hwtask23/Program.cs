// принимает на вход число (N) 
//  выдаёт таблицу кубов чисел от 1 до N


void WriteTableCube (int number)
{
    int i = 1;
    while (i <= number)
    {
        Console.WriteLine($"{i,5}-> {i*i*i,5}");
        i= i+1;
    }
}
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

WriteTableCube (n);
