// принимает на вход три числа и проверяет может ли существовать треугольник с такими сторонами
// каждая сторона треугольника меньше суммы двух других сторон


bool ExistenceOfTriangle(int sideA, int sideB, int sideC)
{
    if(sideA < sideB + sideC && sideB < sideA+ sideC && sideC < sideA+sideB) return true;
    return false;
}

Console.WriteLine ("Введите стороны треугольника: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
bool answer = ExistenceOfTriangle(A,B,C);
string result = answer ? "может" : "не может";
Console.WriteLine ($"Треугольник со сторонами {a}, {b} и {c} существовать {result}");
