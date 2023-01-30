// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int InsertDigit(string text) //Метод пользовательского ввода для целых чисел
{
    int result; bool parse;
    Console.WriteLine(text);
    parse = Int32.TryParse(Console.ReadLine(), out result);
    if (!parse) result = InsertDigit(text);//Если пользователь ввел некорректное значение вызываем повтороно метод.
    return result;
}

int PowerDigit(int n, int m)
{
    if (m == 0) return 1;
    return PowerDigit(n, m - 1) * n;
}

int nUser = InsertDigit("Введите число N:");
int mPower = InsertDigit("Введите степень числа N:");

int power = PowerDigit(nUser, Math.Abs(mPower));
string answer = mPower < 0 ? $"1/{power} =~ {Math.Round((double)1 / power, 4)}" : $"{power}";
Console.WriteLine(answer);
