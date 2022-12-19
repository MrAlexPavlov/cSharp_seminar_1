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

int usNumber = InsertDigit("Введите номер дня недели от 1 до 7:");

if (usNumber < 1 || usNumber > 7) //Если пользователь ввел число не в рамках от 1 до 7 то сообщаем ему об этом
{
    Console.WriteLine($"В неделе 7 дней, а не {usNumber}");
}
else if (usNumber < 6) //Будние дни
{
    Console.WriteLine($"{usNumber} -> нет");
}
else //                 Выходные дни
{ 
    Console.WriteLine($"{usNumber} -> да");
}
