// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
//y = k1 * x + b1,
//y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



int InsertDigit(string text) //Метод пользовательского ввода для целых чисел
{
    int result; bool parse;
    Console.WriteLine(text);
    parse = Int32.TryParse(Console.ReadLine(), out result);
    if (!parse) result = InsertDigit(text);//Если пользователь ввел некорректное значение вызываем повтороно метод.
    return result;
}

(double x, double y, bool cross) FindTheCrossPoint((int b1, int k1, int b2, int k2) numb)//Метод поиска точки пересечения
{
    (double x, double y, bool cross) result = (x: 0, y: 0, cross: true);
    // общем решением системы уровнения будет
    // x = (y - b1) / k1 || x = (y - b2) / k2
    // y = (k1*b2 - k2*b1) / (k1 - k2)

    if (numb.k1 == numb.k2)//Если к1 = к2 решений нет
    {
        result.cross = false;
        return result;
    }

    result.y = (double)(numb.k1 * numb.b2 - numb.k2 * numb.b1) / (numb.k1 - numb.k2);
    //на тот случай если какая-то из прямых паралельна оси х (к1 или к2 равны 0)
    if (numb.k1 != 0)
        result.x = (double)(result.y - numb.b1) / numb.k1;
    else if (numb.k2 != 0)
        result.x = (double)(result.y - numb.b2) / numb.k2;

    return result;
}

//Просим пользователя ввести числа для уровнений
string equationsOfLines = "y = k1 * x + b1;\ny = k2 * x + b2;";
Console.WriteLine($"Ищем точки пересечения двух прямых\n{equationsOfLines}");

var usersNumbers = (b1: 0, k1: 0, b2: 0, k2: 0);
usersNumbers.b1 = InsertDigit("Введите значения b1:");
usersNumbers.k1 = InsertDigit("Введите значения k1:");
usersNumbers.b2 = InsertDigit("Введите значения b2:");
usersNumbers.k2 = InsertDigit("Введите значения k2:");

//Вызываем метод для нахождения точки пересечения
var crossPoint = FindTheCrossPoint(usersNumbers);

//Выводим в консоль уровнения прямых и решение если такое было найдено.
equationsOfLines = $"y = {usersNumbers.k1}x + {usersNumbers.b1};\ny = {usersNumbers.k2}x + {usersNumbers.b2};";
if (crossPoint.cross)
{
    Console.WriteLine($"\nдля прямых:\n{equationsOfLines}");
    Console.WriteLine($"Точка пересечения x = {crossPoint.x} y = {crossPoint.y}");
}
else
{
    Console.WriteLine($"\nдля прямых:\n{equationsOfLines}");
    Console.WriteLine($"Точек пересечения не найдено");
}