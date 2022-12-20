// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int InsertDigit(string text) //Метод ввода пользовательских данных
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int HollidayDayByindex(int weekday)
{
    int res = -1;
    if (weekday > 0 && weekday < 6) res = 0; //Будние дни
    if (weekday == 6 || weekday == 7) res = 1; //Выходные дни
    return res;
}

int holliday = -1, usNumber = 0;
//Просим пользователя ввести число 
//Если пользователь ввел некорректный день недели просим это его сделать еще раз
while (holliday < 0)
{
    usNumber = InsertDigit("Введите номер дня недели от 1 до 7:"); //Метод ввода числа от пользователя
    holliday = HollidayDayByindex(usNumber); //Вызываем метод проверки, введенный день выходной или нет
    if (holliday < 0) Console.WriteLine($"В неделе 7 дней, а не {usNumber}\n");
}

if (holliday == 0) Console.WriteLine($"{usNumber} -> нет");
if (holliday == 1) Console.WriteLine($"{usNumber} -> да");

