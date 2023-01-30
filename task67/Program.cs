// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int InsertDigit(string text) //Метод пользовательского ввода для целых чисел
{
    int result; bool parse;
    Console.WriteLine(text);
    parse = Int32.TryParse(Console.ReadLine(), out result);
    if (!parse) result = InsertDigit(text);//Если пользователь ввел некорректное значение вызываем повтороно метод.
    return result;
}

int SumDigit(int n)
{
    if (n == 0) return 0;
    return SumDigit(n / 10) + n % 10;
}

int nUser = InsertDigit("Введите число N:");

int sum = SumDigit(nUser);
Console.WriteLine(sum);