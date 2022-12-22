// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти:");

int quarter = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Quarter(quarter));

string Quarter (int quart)
{
    if (quart ==1 ) return "xpos>0 && ypos>0";
    if (quart ==2 ) return "xpos<0 && ypos>0";
    if (quart ==3 ) return "xpos<0 && ypos<0";
    if (quart ==4 ) return "xpos<0 && ypos<0";
    return $"Не верный ввод. Четверти {quart} не существует";
}
