// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите число:");
int usernumber = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите второе число:");
int usernumber2 = Convert.ToInt32 (Console.ReadLine());

string Proverka (int us1, int us2)
{
    if ( us1 % us2 == 0 ) 
    {
        return $"{us1}, {us2} -> кратно" ;
    } else {
        return $"{us1}, {us2} -> не кратно, остаток "+(us1 % us2);
    }
}
string res = Proverka(usernumber,usernumber2);
Console.WriteLine(res);

