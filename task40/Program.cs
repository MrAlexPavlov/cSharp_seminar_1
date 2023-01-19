// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон

int InsertDigit(string text) //Метод пользовательского ввода
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int lenSide1 = InsertDigit("Введите длиину первой стороны треугольника");
int lenSide2 = InsertDigit("Введите длиину второй стороны треугольника");
int lenSide3 = InsertDigit("Введите длиину третьей стороны треугольника");

if (lenSide1>(lenSide2+lenSide3) || lenSide2>(lenSide1+lenSide3) || lenSide3>(lenSide1+lenSide2))
{
    Console.WriteLine("Такого треугольника не существует");
}
else
{
    Console.WriteLine($"Данный треугольник со сторонами {lenSide1}, {lenSide2}, {lenSide3} существует!");
}
