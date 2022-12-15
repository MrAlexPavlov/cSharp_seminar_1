//  Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите номер дня недели:");
int usernumber = Convert.ToInt32 (Console.ReadLine());
string weekday = "";

if (usernumber == 1) {
    weekday = "Понедельник";
} else if (usernumber == 2) {
    weekday = "Вторник";
} else if (usernumber == 3) {
    weekday = "Среда";
} else if (usernumber == 4) {
    weekday = "Четверг";
} else if (usernumber == 5) {
    weekday = "Пятница";
} else if (usernumber == 6) {
    weekday = "Суббота";
} else if (usernumber == 7) {
    weekday = "Воскресенье";
}

Console.WriteLine($"{usernumber} -> {weekday}");