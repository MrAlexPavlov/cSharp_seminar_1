// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да



int RevertDigit(int digitNum)//Метод для разворота числа. С учетом того, что оно может быть меньше нуля.
{
    int result = 0;
    int a = Math.Abs(digitNum);

    while (a >= 1)
    {
        result = result * 10 + (a % 10);
        a = a / 10;
    }

    if (digitNum < 0) result = -result;
    return result;
}

int InsertDigit(string text) //Метод пользовательского ввода
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int number = InsertDigit("Введите число:");
int altNumber = RevertDigit(number);// зеркалим полученное от пользователя число 123 -> 321

if (number == altNumber) // Если первоночальное число равно зеркальному, то значит это число палиндром
{
    Console.Write($"{number} -> да");
}
else
{
    Console.Write($"{number} -> нет");
}